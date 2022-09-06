using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ParticipantManager : IParticipantService
    {
        private readonly IParticipantDal _participantDal;

        public ParticipantManager(IParticipantDal participantDal)
        {
            _participantDal = participantDal;

        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<Participant>> GetAll()
        {
            return new SuccessDataResult<List<Participant>>(_participantDal.GetAll(), Messages.ParticipantListed);
        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<Participant> GetByParticipantId(string id)
        {
            return new SuccessDataResult<Participant>(_participantDal.Get(pm => pm.Id == id));
        }
        [SecuredOperation("suser,admin,Customer.Add")]
        public IResult Add(Participant participant)
        {

            _participantDal.Add(participant);
            return new SuccessResult();
        }
        [SecuredOperation("suser,admin,Customer.Update")]
        public IResult Update(Participant participant)
        {
            _participantDal.Update(participant);
            return new SuccessResult(Messages.Update);
        }
        [SecuredOperation("suser,admin,Customer.Delete")]
        public IResult Delete(Participant participant)
        {
            _participantDal.Delete(participant);
            return new SuccessDataResult<List<Participant>>(Messages.Deleted);
        }




    }
}
