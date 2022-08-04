using Business.Absract.MeetingsService;
using Core.Utilities.Results;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.MeetingsManager
{
    public class FinishedMeetingsManager : IFinishedMeetingsService
    {
        public IResult Add(FinishedMeetings finishedMeetings)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int finishedMeetingsId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<FinishedMeetings>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<FinishedMeetings>> GetAllByFinishedMeetingsId(int finishedMeetingsId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<FinishedMeetings>> GetAllParticiPants(string participant)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<FinishedMeetings>> GetByFinishedMeetingId(int finishedMeetingId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(FinishedMeetings finishedMeetings)
        {
            throw new NotImplementedException();
        }
    }
}
