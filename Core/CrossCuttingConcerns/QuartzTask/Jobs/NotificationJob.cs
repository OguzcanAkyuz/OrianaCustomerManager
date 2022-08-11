using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.QuartzTask.Jobs
{
    public class NotificationJob : IJob
    {
        private readonly ILogger<NotificationJob> _logger;

        public NotificationJob(ILogger<NotificationJob> logger)
        {
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation($"Notify User at{DateTime.Now}and Jobtype:{context.JobDetail.JobType}");
            return Task.CompletedTask;
        }
    }
}
