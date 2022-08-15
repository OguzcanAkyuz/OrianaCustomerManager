using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_PotentialCustomerCollection : ICollection
    {
        public MongoDB_PotentialCustomerCollection()
        {
            CollectionName = "PotentialCustomers";
        }

        public string CollectionName { get; set; }
    }
}
