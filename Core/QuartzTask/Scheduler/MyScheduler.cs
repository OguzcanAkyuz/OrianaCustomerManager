using Microsoft.Extensions.Hosting;
using Quartz;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Core.QuartzTask.Scheduler
{
    public class MyScheduler : IHostedService
    {
        public IScheduler Scheduler { get; set; }
        private readonly IJobFactory jobFactory;
        private readonly ISchedulerFactory schedulerFactory;
        //burası daha bitmedi gizleyebiliriz.
        public MyScheduler(IScheduler scheduler,IJobFactory jobFactory)
        {
            this.jobFactory = jobFactory;
            this.schedulerFactory = schedulerFactory;
        }
        public async System.Threading.Tasks.Task StartAsync(CancellationToken cancellationToken)
        {
            //Scheduler = await schedulerFactory.GetScheduler();
            //Scheduler.JobFactory = jobFactory;

            //await Scheduler.Start(cancellationToken);
            await System.Threading.Tasks.Task.CompletedTask;
        }

        public async System.Threading.Tasks.Task StopAsync(CancellationToken cancellationToken)
        {
            await Scheduler.Shutdown();
        }
    }
}
