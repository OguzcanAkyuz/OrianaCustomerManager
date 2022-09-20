using Business.Abstract.MeetingsService;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract.IMeetingsDal;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.MeetingsManager
{
    public class FinishedMeetingManager : IFinishedMeetingService
    {
        private readonly IFinishedMeetingDal _finishedMeetingDal;

        public FinishedMeetingManager(IFinishedMeetingDal finishedMeetingDal)
        {
            _finishedMeetingDal = finishedMeetingDal;
        }

        public IResult Add(FinishedMeeting finishedMeeting)
        {
           
            _finishedMeetingDal.Add(finishedMeeting);
            return new SuccessResult(Messages.SuccesResult);
        }

        

        public IDataResult<List<FinishedMeeting>> GetAll()
        {
            return new SuccessDataResult<List<FinishedMeeting>>(_finishedMeetingDal.GetAll(), Messages.FinishedMeetingListed);
        }

       

        public IDataResult<List<FinishedMeeting>> GetAllParticiPants(string participantId)
        {
            return new SuccessDataResult<List<FinishedMeeting>>(_finishedMeetingDal.GetAll(f => f.Id == participantId));
        }

        public IDataResult<FinishedMeeting> GetByFinishedMeetingId(string finishedMeetingId)
        {
            return new SuccessDataResult<FinishedMeeting>(_finishedMeetingDal.Get(f => f.Id == finishedMeetingId));
        }
   
        public IResult Delete(string finishedMeetingId)
        {
            var finishedMeeting = _finishedMeetingDal.Get(f => f.Id == finishedMeetingId);
            _finishedMeetingDal.Delete(finishedMeeting);
            return new SuccessDataResult<List<FinishedMeeting>>(Messages.Deleted);
        }
        public IResult Update(string finishedMeetingId)
        {   
            var finishedMeeting=_finishedMeetingDal.Get(f => f.Id == finishedMeetingId);
            
            _finishedMeetingDal.Update(finishedMeeting);
            return new SuccessResult(Messages.Update);
        }
    }
}
