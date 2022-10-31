using Business.Abstract.MeetingsService;
using Core.CrossCuttingConcerns.EMailService;
using Core.Entities.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Business.Jobs
{
    public class MeetingsJob : IJob
    {
        private IScheduledMeetingService _scheduledMeetingDal;
    
        private readonly IEMailManager _eMailManager;
        private IConfiguration _configuration;
        public MeetingsJob(IScheduledMeetingService scheduledMeetingDal,IEMailManager eMailManager, IConfiguration configuration)
        {
            _configuration = configuration;
            _scheduledMeetingDal = scheduledMeetingDal;
            _eMailManager = eMailManager;

        }

        public async Task Execute(IJobExecutionContext context)
        {
            var meetingJobs = _scheduledMeetingDal.GetByScheduledMeetingDate(DateTime.Now.ToString("yyyy-MM-dd"));
            var eMailConfig = _configuration.GetSection("EmailConfiguration").Get<EMailConfig>();
            var emails = new List<string>();

            emails.Add("halit.ozer@ozztech.net");
            emails.Add("akyuzoguz34@gmail.com");
            eMailConfig.To = emails;
            foreach (var meetingJob in meetingJobs.Data)
            {
                _eMailManager.SendEMail(eMailConfig, new EMailContent { Subject = "Meeting Time", Body = $"{meetingJob.MeetingTitle}",IsBodyHtml = true });
            }
            
        

        }
    }

}
