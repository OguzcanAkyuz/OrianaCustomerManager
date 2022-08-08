using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Entities.Concrete
{
    public class PotentialCustomer : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
       
        public string PotentialCustomerName { get; set; }
        public string PotentialCustomerSurname { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public string Adress { get; set; }
        public string Company { get; set; }

        public string Position { get; set; }

        public string Note { get; set; }
        public DateTime DateOfUpload { get; set; }



    }
}
