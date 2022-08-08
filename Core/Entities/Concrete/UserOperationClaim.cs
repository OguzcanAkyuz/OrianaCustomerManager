using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim:IEntity
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

    }
}
