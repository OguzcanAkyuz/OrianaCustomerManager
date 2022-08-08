using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_AbroadInvestmentRelationCollection : ICollection
    {
        public MongoDB_AbroadInvestmentRelationCollection()
        {
            CollectionName = "AbroadInvestmentRelations";
        }

        public string CollectionName { get; set; }
    }
}
