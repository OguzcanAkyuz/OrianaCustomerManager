using Core.DataAccess;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract.IMeetingsDal
{
    public interface IScheduledMeetingDal : IEntityRepository<ScheduledMeeting>
    {
    }
}
