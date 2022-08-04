using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.Meetings
{
    public class FinishedMeetings : IEntity
    {
        public int FinishedMeetingsId { get; set; }
        public string CustomerInformation { get; set; }
        public string Participants { get; set; }

        public string MeetingSubject { get; set; }
        public bool MeetingResult { get; set; }

        public string MeetingTitle { get; set; }

        public string CompanyName { get; set; }
        public string CompanyAdress { get; set; }
        public string CompanyBusinessArea { get; set; }
        public string CompanyWebAdress { get; set; }
        public string ExecutiveName { get; set; }
        public int ExecutivePhoneNumber { get; set; }

        public string ExecutiveEmail { get; set; }



    }
}
