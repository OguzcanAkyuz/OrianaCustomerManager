using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public  interface ICollection
    {
        string CollectionName { get; set; }
    }
}
