using Core.Entities;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.Meetings
{
    public class FinishedMeeting : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
       
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
