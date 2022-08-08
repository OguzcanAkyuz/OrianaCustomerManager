using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_RoutineServiceCollection : ICollection
    {
        public MongoDB_RoutineServiceCollection()
        {
            CollectionName = "RoutineServices";
        }

        public string CollectionName { get; set; }
    }
}

