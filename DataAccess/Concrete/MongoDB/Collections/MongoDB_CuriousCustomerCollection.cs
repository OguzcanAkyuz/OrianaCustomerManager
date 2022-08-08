using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_CuriousCustomerCollection : ICollection
    {
        public MongoDB_CuriousCustomerCollection()
        {
            CollectionName = "CuriousCustomer";
        }
        public string CollectionName { get; set; }
    }
}
