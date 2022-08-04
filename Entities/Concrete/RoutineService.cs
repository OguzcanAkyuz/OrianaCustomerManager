using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class RoutineServices : IEntity
    {
       
        public string Product { get; set; }
        public string CustomerName { get; set; }

        public string RoutineServiceDescription { get; set; }
        public DateTime RoutineServiceDate { get; set; }
        public float RoutineServiceTime { get; set; }

        public string Officer { get; set; }

        public int RoutineServicesId { get; set; }



    }
}
