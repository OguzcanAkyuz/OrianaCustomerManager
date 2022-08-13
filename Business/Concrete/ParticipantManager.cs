using Business.Abstract;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ParticipantManager : IParticipantService
    {
        private readonly IParticipantDal _participantDal;

        public ParticipantManager(IParticipantDal participantDal)
        {
            _participantDal = participantDal;

        }
        public IDataResult<List<Participant>> GetAll()
        {
            return new SuccessDataResult<List<Participant>>(_participantDal.GetAll(),Messages.ParticipantListed);
        }

        public IDataResult<Participant> GetByParticipantId(string id)
        {
            return new SuccessDataResult<Participant>(_participantDal.Get(pm => pm.Id == id));
        }

        public IResult Add(Participant participant)
        {
            
            _participantDal.Add(participant);
            return new SuccessResult();
        }

        public IResult Update(Participant participant)
        {
            _participantDal.Update(participant);
            return new SuccessResult(Messages.Update);
        }

        public IResult Delete(Participant participant)
        {
            _participantDal.Delete(participant);
            return new SuccessDataResult<List<Participant>>(Messages.Deleted);      
        }

       

   
    }
}
