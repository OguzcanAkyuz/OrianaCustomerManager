using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_UserOperationClaimsCollection:ICollection
    {

        public MongoDB_UserOperationClaimsCollection()
        {
            CollectionName = "UserOperationClaims";
        }

        public string CollectionName { get; set; }
    }
}
