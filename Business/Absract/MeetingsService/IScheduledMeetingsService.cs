using Core.Utilities.Results;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Absract.MeetingsService
{
    public interface IScheduledMeetingsService 
    {
        IDataResult<List<ScheduledMeetings>> GetAll();
        IDataResult<List<ScheduledMeetings>> GetAllByScheduledMeetignsId(int scheduledMeetingsId);
        IDataResult<List<ScheduledMeetings>> GetByScheduledMeetingId(int scheduledMeetingId);
        IDataResult<List<ScheduledMeetings>> GetAllParticiPants(string participant);

        IResult Add(ScheduledMeetings scheduledMeetings);
        IResult Update(ScheduledMeetings scheduledMeetings);

        IResult Delete(int scheduledMeetingsId);
    }
}
