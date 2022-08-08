using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_CustomerCollection : ICollection
    {
        public MongoDB_CustomerCollection()
        {
            CollectionName = "Customers";
        }

        public string CollectionName { get; set; }
    }
}
