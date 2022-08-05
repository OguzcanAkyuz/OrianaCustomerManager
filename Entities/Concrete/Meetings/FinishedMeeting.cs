using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.Meetings
{
    public class FinishedMeeting : IEntity
    {
        public string FinishedMeetingsId { get; set; }
        public string CustomerInformation { get; set; }
        public string ParticipantsId { get; set; }

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
