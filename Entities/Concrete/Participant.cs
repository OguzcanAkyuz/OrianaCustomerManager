using Core.Entities;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Participant:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
       
        public string ParticipantName { get; set; }
        public string ParticipantSurname { get; set; }

        public string Company { get; set; }

        public string  PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }

        public string ProductId { get; set; }

    }
}
