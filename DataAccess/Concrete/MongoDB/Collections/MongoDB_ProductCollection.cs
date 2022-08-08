using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_ProductCollection : ICollection
    {
        public string CollectionName { get; set ; }
        public MongoDB_ProductCollection()
        {
            CollectionName = "Products";
        }
    }
}
