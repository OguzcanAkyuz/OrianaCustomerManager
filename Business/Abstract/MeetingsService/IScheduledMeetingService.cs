using Core.Utilities.Results;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract.MeetingsService
{
    public interface IScheduledMeetingService 
    {
        IDataResult<List<ScheduledMeeting>> GetAll();
        IDataResult<ScheduledMeeting> GetByScheduledMeetingId(string scheduledMeetingId);
        IDataResult<List<ScheduledMeeting>> GetAllParticiPants(string participant);

        IResult Add(ScheduledMeeting scheduledMeetings);
        IResult Update(ScheduledMeeting scheduledMeeting);

        IResult Delete(ScheduledMeeting scheduledMeeting);
    }
}
