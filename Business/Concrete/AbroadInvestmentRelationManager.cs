using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Core.CrossCuttingConcerns.EMailService;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class AbroadInvestmentRelationManager : IAbroadInvestmentRelationService
    {
        private readonly IAbroadInvestmentRelationDal _abroadInvestmentRelationDal;


        public AbroadInvestmentRelationManager(IAbroadInvestmentRelationDal abroadInvestmentRelationDal, IEMailManager iEMailManager)
        {
            _abroadInvestmentRelationDal = abroadInvestmentRelationDal;

        }
        [SecuredOperation("suser,admin,AbroadInvestmentRelation.Add")]
        public IResult Add(AbroadInvestmentRelation abroadInvestmentRelations)
        {
            _abroadInvestmentRelationDal.Add(abroadInvestmentRelations);

            return new SuccessResult(Messages.SuccesResult);
        }


        [SecuredOperation("suser,admin,AbroadInvestmentRelation.Get")]
        public IDataResult<List<AbroadInvestmentRelation>> GetAll()
        {

            return new SuccessDataResult<List<AbroadInvestmentRelation>>(_abroadInvestmentRelationDal.GetAll(), Messages.InvestmentRelationsListed); //mesajı düzelt
        }

        [SecuredOperation("suser,admin,AbroadInvestmentRelation.Get")]
        public IDataResult<AbroadInvestmentRelation> GetByAbroadInvestmentRelationsId(string abroadInvestmentRelationId)
        {
            return new SuccessDataResult<AbroadInvestmentRelation>(_abroadInvestmentRelationDal.Get(ar => ar.Id == abroadInvestmentRelationId));
        }

        [SecuredOperation("suser,admin,AbroadInvestmentRelation.Get")]
        public IResult Delete(string abroadInvestmentRelationId)
        {
            var abroadInvestmentRelation = _abroadInvestmentRelationDal.Get(a => a.Id == abroadInvestmentRelationId);
            _abroadInvestmentRelationDal.Delete(abroadInvestmentRelation);
            return new SuccessDataResult<List<AbroadInvestmentRelation>>(Messages.Deleted);
        }

        [SecuredOperation("suser,admin,AbroadInvestmentRelation.Update")]
        public IResult Update(string abroadInvestmentRelationId)
        {
            var abroadInvestmentRelation = _abroadInvestmentRelationDal.Get(a => a.Id == abroadInvestmentRelationId);
            _abroadInvestmentRelationDal.Update(abroadInvestmentRelation);
            return new SuccessResult(Messages.Update);
        }
        [SecuredOperation("suser,admin,AbroadInvestmentRelation.Get")]
        public IDataResult<AbroadInvestmentRelation> GetAllCountry(string country)
        {
            return new SuccessDataResult<AbroadInvestmentRelation>(_abroadInvestmentRelationDal.Get(ar => ar.Country == country));
        }
    }

}


