using Business.Abstract;
using Business.Abstract.MeetingsService;
using Business.Constans;

using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Abstract.IMeetingsDal;
using Entities.Concrete;
using Entities.Concrete.Meetings;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.MeetingsManager
{
    public class ScheduledMeetingManager : IScheduledMeetingService
    {   
        private readonly IScheduledMeetingDal _scheduledMeetingDal;
        private readonly IParticipantService _participantDal;
       

        public ScheduledMeetingManager(IScheduledMeetingDal scheduledMeetingDal,IParticipantService participantService)
        {
            _scheduledMeetingDal = scheduledMeetingDal;
            _participantDal = participantService;
        }


        public IResult Add(ScheduledMeeting scheduledMeeting)
        {
        
            _scheduledMeetingDal.Add(scheduledMeeting);
            return new SuccessResult(Messages.SuccesResult);
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
            return new SuccessDataResult<ScheduledMeeting>(_scheduledMeetingDal.Get(s => s.Id == scheduledMeetingId));
        }


        public IResult Delete(ScheduledMeeting scheduledMeeting)
        {
            _scheduledMeetingDal.Delete(scheduledMeeting);
            return new SuccessDataResult<List<ScheduledMeeting>>(Messages.Deleted);
        }

        public IResult Update(ScheduledMeeting scheduledMeeting)
        {
            _scheduledMeetingDal.Update(scheduledMeeting);
            return new SuccessResult(Messages.Update);
        }

       
    }
}
