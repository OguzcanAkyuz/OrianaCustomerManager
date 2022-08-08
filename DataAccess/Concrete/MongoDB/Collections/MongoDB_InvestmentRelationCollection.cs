using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_InvestmentRelationCollection : ICollection
    {
      public  MongoDB_InvestmentRelationCollection()
        {
            CollectionName = "InvestmentRelations";
        }
        public string CollectionName { get; set; }
    }
}
