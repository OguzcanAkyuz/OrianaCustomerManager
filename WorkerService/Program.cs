using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Quartz;
using System.Threading.Tasks;
using Quartz.Impl.Calendar;
using Quartz.Impl.Matchers;
using System.Globalization;
using Business.Jobs;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using Business.DependencyResolvers.Autofac;

namespace WorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterModule(new AutofacBusinessModule());

            })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                    services.Configure<QuartzOptions>(hostContext.Configuration.GetSection("Quartz"));
                    services.Configure<QuartzOptions>(options =>
                    {
                        options.Scheduling.IgnoreDuplicates = true; // default: false
                        options.Scheduling.OverWriteExistingData = true; // default: true
                    });

                    services.AddQuartz(q =>
                    {
                    
                        q.SchedulerId = "Scheduler-Core";

                        q.UseMicrosoftDependencyInjectionJobFactory();

                        q.UseSimpleTypeLoader();
                        q.UseInMemoryStore();
                        q.UseDefaultThreadPool(tp =>
                        {
                            tp.MaxConcurrency = 10;
                        });

                        var jobKey = new JobKey("awesome job", "awesome group");
                        q.AddJob<MeetingsJob>(jobKey, j => j
                .WithDescription("my awesome job")
            );


                        q.AddTrigger(t => t
                            .WithIdentity("Daily Trigger")
                            .ForJob(jobKey)
                            .StartAt(DateBuilder.EvenSecondDate(DateTimeOffset.UtcNow.AddSeconds(5)))
                            .WithDailyTimeIntervalSchedule(x => x.WithInterval(10, IntervalUnit.Second))

                                                );

                      

                    
                   
                    });
                    services.AddQuartzHostedService(options =>
                    {
                        options.WaitForJobsToComplete = true;
                    });


                });
    }
}
