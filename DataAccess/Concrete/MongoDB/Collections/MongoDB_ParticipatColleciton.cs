using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_ParticipatColleciton : ICollection
    {
        public MongoDB_ParticipatColleciton()
        {
            CollectionName = "Participants";
        }

        public string CollectionName { get; set; }
    }
}
