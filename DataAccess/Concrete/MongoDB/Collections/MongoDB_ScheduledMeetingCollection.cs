using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_ScheduledMeetingCollection : ICollection
    {
        public MongoDB_ScheduledMeetingCollection()
        {
            CollectionName = "ScheduledMeetings";
        }
        public string CollectionName { get; set; }
    }
}
