using Microsoft.Extensions.Hosting;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.QuartzTask.JobFactory
{
    public class MyScheduler : IHostedService
    {
        public IScheduler Scheduler { get; set; }
        private readonly IJobFactory jobFactory;
        private readonly ISchedulerFactory schedulerFactory;
        private StdSchedulerFactory factory = new StdSchedulerFactory();
    
        



        public MyScheduler(IScheduler scheduler,IJobFactory jobFactory)
        {
            
            jobFactory = jobFactory;
            schedulerFactory = schedulerFactory;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Scheduler = await schedulerFactory.GetScheduler();
            Scheduler.JobFactory = jobFactory;
            await Scheduler.Start(cancellationToken);
            await Task.CompletedTask;
        }


        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Scheduler.Shutdown();
        }
    }
}
