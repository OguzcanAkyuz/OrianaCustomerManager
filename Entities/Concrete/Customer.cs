﻿using Core.Entities;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        public string ProductId { get; set; }
        public string PurchaseDate { get; set; }
        public string LicenseTerm { get; set; } 
        public string LisenceEndDate { get; set; }
        public  string PurchasePrice { get; set; } 
        public string CustomerNote { get; set; }
        public string ProductVersion { get; set; } 
        public string CustomerCompanyName { get; set; }
        public string CustomerCompanyAdress { get; set; }
        public string CompanyBusinessArea { get; set; }
        public string CompanyWebAdress { get; set; }
        public string ExecutiveName { get; set; }
        public string  ExecutiveSurname { get; set; }
        public string ExecutivePhoneNumber { get; set; } 

        public string ExecutiveEmail { get; set; }
     
    }
}
