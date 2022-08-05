using Core.Utilities.Results;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract.MeetingsService
{
    public interface IFinishedMeetingService
    {
        IDataResult<List<FinishedMeeting>> GetAll();
  
        IDataResult<List<FinishedMeeting>> GetByFinishedMeetingId(string finishedMeetingId);
        IDataResult<List<FinishedMeeting>> GetAllParticiPants(string participant);

        IResult Add(FinishedMeeting finishedMeetings);
        IResult Update(FinishedMeeting finishedMeetings);

        IResult Delete(int finishedMeetingsId);

    }
}
