using Business.Absract.MeetingsService;
using Core.Utilities.Results;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.MeetingsManager
{
    public class ScheduledMeetingsManager : IScheduledMeetingsService
    {
        public IResult Add(ScheduledMeetings scheduledMeetings)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int scheduledMeetingsId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ScheduledMeetings>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ScheduledMeetings>> GetAllByScheduledMeetignsId(int scheduledMeetingsId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ScheduledMeetings>> GetAllParticiPants(string participant)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ScheduledMeetings>> GetByScheduledMeetingId(int scheduledMeetingId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(ScheduledMeetings scheduledMeetings)
        {
            throw new NotImplementedException();
        }
    }
}
