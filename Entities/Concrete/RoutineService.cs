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
        public DateTime RoutineServiceDate { get; set; }
        public float RoutineServiceTime { get; set; }

        public string Officer { get; set; }

        public string RoutineServiceId { get; set; }



    }
}
