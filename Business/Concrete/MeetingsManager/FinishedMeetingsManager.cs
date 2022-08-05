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
        IFinishedMeetingDal _finishedMeetingDal;

        public FinishedMeetingManager(IFinishedMeetingDal finishedMeetingDal)
        {
            _finishedMeetingDal = finishedMeetingDal;
        }

        public IResult Add(FinishedMeeting finishedMeeting)
        {
            IResult result = BusinessRules.Run(CheckIfFinishedMeetingIdExitis(finishedMeeting.FinishedMeetingsId));
            if (result == null)
            {
                return new ErrorResult("İçeriyi Doldur"); //mesajları kontrol et
            }
            _finishedMeetingDal.Add(finishedMeeting);
            return new SuccessResult(Messages.SuccesResult);
        }

        

        public IDataResult<List<FinishedMeeting>> GetAll()
        {
            return new SuccessDataResult<List<FinishedMeeting>>(_finishedMeetingDal.GetAll(), Messages.FinishedMeetingListed);
        }

       

        public IDataResult<List<FinishedMeeting>> GetAllParticiPants(string participantId)
        {
            return new SuccessDataResult<List<FinishedMeeting>>(_finishedMeetingDal.GetAll(f => f.ParticipantsId == participantId));
        }

        public IDataResult<List<FinishedMeeting>> GetByFinishedMeetingId(string finishedMeetingId)
        {
            return new SuccessDataResult<List<FinishedMeeting>>(_finishedMeetingDal.GetAll(f => f.FinishedMeetingsId == finishedMeetingId));
        }
        private IResult CheckIfFinishedMeetingIdExitis(string finishedMeetingId)
        {
            var result = _finishedMeetingDal.GetAll(s => s.FinishedMeetingsId == finishedMeetingId).Count;
            if (result <= 0)
            {
                return new ErrorResult(Messages.ErrorResult);
            }
            return new SuccessResult();
        }
        public IResult Delete(int finishedMeetingsId)
        {
            throw new NotImplementedException();
        }
        public IResult Update(FinishedMeeting finishedMeetings)
        {
            throw new NotImplementedException();
        }
    }
}
