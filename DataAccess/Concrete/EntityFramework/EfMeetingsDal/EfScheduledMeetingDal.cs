using Core.DataAccess.EntityFramework;
using DataAccess.Abstract.IMeetingsDal;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.EfMeetingsDal
{
    public class EfScheduledMeetingDal:EfEntityRepositoryBase<ScheduledMeeting,CustomerManagerContext>,IScheduledMeetingDal
    {
    }
}
