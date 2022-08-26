using Core.Entities;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace Entities.Concrete
{
    public class RoutineService : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
      
        public string CustomerName { get; set; }

        public string RoutineServiceDescription { get; set; }
        public string RoutineServiceDate { get; set; }
        public string RoutineServiceTime { get; set; }

        public string Officer { get; set; }
        
        public string ProductId { get; set; }

      
        public string PersonSurname { get; set; }


    }
}
