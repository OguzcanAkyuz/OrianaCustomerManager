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

        IDataResult<List<ScheduledMeeting>> GetByScheduledMeetingDate(string scheduledMeetingDate);

        IResult Add(ScheduledMeeting scheduledMeetings);
        IResult Update(ScheduledMeeting scheduledMeeting);

        IResult Delete(string scheduledMeetingId);

    }
}
