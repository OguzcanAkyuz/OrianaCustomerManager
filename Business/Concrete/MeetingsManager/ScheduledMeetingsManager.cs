using Business.Abstract;
using Business.Abstract.MeetingsService;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Abstract.IMeetingsDal;
using Entities.Concrete;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.MeetingsManager
{
    public class ScheduledMeetingManager : IScheduledMeetingService
    {
        IScheduledMeetingDal _scheduledMeetingDal;
        IParticipantService _participantDal;

        public ScheduledMeetingManager(IScheduledMeetingDal scheduledMeetingDal,IParticipantService participantService)
        {
            _scheduledMeetingDal = scheduledMeetingDal;
            _participantDal = participantService;
        }


        public IResult Add(ScheduledMeeting scheduledMeeting)
        {
            IResult result = BusinessRules.Run(CheckIfScheduledMeetingIdExitis(scheduledMeeting.ScheduledMeetingsId));
            if(result == null)
            {
                return new ErrorResult("İçeriyi Doldur"); //mesajları kontrol et
            }
            _scheduledMeetingDal.Add(scheduledMeeting);
            return new SuccessResult(Messages.SuccesResult);
        }

        public IResult Delete(string scheduledMeetingsId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ScheduledMeeting>> GetAll()
        {
            return new SuccessDataResult<List<ScheduledMeeting>>(_scheduledMeetingDal.GetAll(), Messages.ScheduledMeetingListed);
        }

      

        public IDataResult<List<ScheduledMeeting>> GetAllParticiPants(string participantId)
        {
            return new SuccessDataResult<List<ScheduledMeeting>>(_scheduledMeetingDal.GetAll(s => s.ParticipantsId == participantId));

            
        }

        public IDataResult<ScheduledMeeting> GetByScheduledMeetingId(string scheduledMeetingId)
        {
            return new SuccessDataResult<ScheduledMeeting>(_scheduledMeetingDal.Get(s => s.ScheduledMeetingsId == scheduledMeetingId));
        }

        private IResult CheckIfScheduledMeetingIdExitis(string scheduledMeetingId)
        {
            var result =_scheduledMeetingDal.GetAll(s=>s.ScheduledMeetingsId == scheduledMeetingId).Count;
            if (result <= 0)
            {
                return new ErrorResult(Messages.ErrorResult);
            }
            return new SuccessResult();
        }
      

        public IResult Update(ScheduledMeeting scheduledMeetings)
        {
            throw new NotImplementedException();
        }
    }
}
