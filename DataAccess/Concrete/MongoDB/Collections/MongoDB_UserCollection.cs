using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_UserCollection :ICollection
    { 
        
        public MongoDB_UserCollection()
        {
            CollectionName = "UserList";
        }

        public string CollectionName { get; set; }
    }
}
