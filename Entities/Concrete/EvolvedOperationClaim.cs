
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class EvolvedOperationClaim 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public int Id { get; set; }

        public string OperationClaimId { get; set; }
        public string UserId { get; set; }



    }
}
