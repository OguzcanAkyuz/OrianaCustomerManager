using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Entities.Concrete
{
    public class AbroadInvestmentRelation : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
      

        public string AbroadInvestorName { get; set; }
        public string AbroadInvestorSurname { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public string Adress { get; set; }
        public string Company { get; set; }

        public string Position { get; set; }

        public string Note { get; set; }
        public string DateOfUpload { get; set; }

        public string Country { get; set; }
   
    }
}
