using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_FinishedMeetingCollection : ICollection
    {
        public MongoDB_FinishedMeetingCollection()
        {
            CollectionName = "FinishedMeetings";
        }
        public string CollectionName { get; set; }
    }
}
