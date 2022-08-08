using Core.Entities;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class InvestmentRelation : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string InvestmentRelationId { get; set; }
        public string InvestorName { get; set; }
        public string InvestorSurname { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public string Adress { get; set; }
        public string Company { get; set; }

        public string Position { get; set; }

        public string Note { get; set; }
        public DateTime DateOfUpload { get; set; }
    }
}
