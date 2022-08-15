using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_ParticipantCollection : ICollection
    {
        public MongoDB_ParticipantCollection()
        {
            CollectionName = "Participants";
        }

        public string CollectionName { get; set; }
    }
}
