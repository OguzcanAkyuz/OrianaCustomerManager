using Core.Utilities.Results;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Absract.MeetingsService
{
    public interface IFinishedMeetingsService
    {
        IDataResult<List<FinishedMeetings>> GetAll();
        IDataResult<List<FinishedMeetings>> GetAllByFinishedMeetingsId(int finishedMeetingsId);
        IDataResult<List<FinishedMeetings>> GetByFinishedMeetingId(int finishedMeetingId);
        IDataResult<List<FinishedMeetings>> GetAllParticiPants(string participant);

        IResult Add(FinishedMeetings finishedMeetings);
        IResult Update(FinishedMeetings finishedMeetings);

        IResult Delete(int finishedMeetingsId);

    }
}
