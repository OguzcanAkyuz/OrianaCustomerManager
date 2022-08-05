using Business.Abstract;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ParticipantManager : IParticipantService
    {
        IParticipantDal _participantDal;
        public IDataResult<List<Participant>> GetAll()
        {
            return new SuccessDataResult<List<Participant>>(_participantDal.GetAll(),Messages.ParticipantListed);
        }

        public IDataResult<Participant> GetByParticipantId(string id)
        {
            return new SuccessDataResult<Participant>(_participantDal.Get(pm => pm.ParticipantId == id));
        }

        public IResult Add(Participant participant)
        {
            IResult result= BusinessRules.Run(CheckIfParticipantIdExitis(participant.ParticipantId)));
            if (result == null)
            {
                return new ErrorResult("Id Boş olamaz");
            }
            return new SuccessResult();
        }

        public IResult Update(Participant participant)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Participant participant)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfParticipantIdExitis(string participantId)
        {
            var result =_participantDal.GetAll(pr=>pr.ParticipantId == participantId);
            if(result == null)
            {
                return new ErrorResult(Messages.ParticipantError);
            }
            return new SuccessResult();
        }

   
    }
}
