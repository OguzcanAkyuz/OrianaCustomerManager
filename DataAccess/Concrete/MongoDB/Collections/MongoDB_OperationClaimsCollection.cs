using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_OperationClaimsCollection :ICollection
    {

        public MongoDB_OperationClaimsCollection()
        {
            CollectionName = "OperationClaims";
        }

        public string CollectionName { get; set; }
    }
}
