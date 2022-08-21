using Core.DataAccess.Databases.MongoDB;
using DataAccess.Abstract.IMeetingsDal;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Utilities
{
    public class MongoDB_ScheduledMeetingDal : MongoDB_RepositoryBase<ScheduledMeeting, MongoDB_Context<ScheduledMeeting, MongoDB_ScheduledMeetingCollection>>, IScheduledMeetingDal
    {
    }
}
