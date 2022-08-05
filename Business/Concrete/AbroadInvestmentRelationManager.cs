using Business.Abstract;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AbroadInvestmentRelationManager : IAbroadInvestmentRelationService
    {
        IAbroadInvestmentRelationDal _abroadInvestmentRelationDal;

        public AbroadInvestmentRelationManager(IAbroadInvestmentRelationDal abroadInvestmentRelationDal)
        {
            _abroadInvestmentRelationDal = abroadInvestmentRelationDal;

        }
        public IResult Add(AbroadInvestmentRelation abroadInvestmentRelations)
        {
            IResult result = BusinessRules.Run(CheckIfAbroadInvestmentRelationExitis(abroadInvestmentRelations.AbroadInvestorId));
            if (result != null)
            {
                return new ErrorResult("Başarısız");       //Parantez içini değiştir.
            }
            _abroadInvestmentRelationDal.Add(abroadInvestmentRelations);
            return new SuccessResult(Messages.InvestmentRelationsSuccess);
        }

        public IResult Delete(AbroadInvestmentRelation abroadInvestmentRelations)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<AbroadInvestmentRelation>> GetAll()
        {
            return new SuccessDataResult<List<AbroadInvestmentRelation>>(_abroadInvestmentRelationDal.GetAll(), Messages.InvestmentRelationsListed); //mesajı düzelt
        }

       
        public IDataResult<AbroadInvestmentRelation> GetByAbroadInvestmentRelationsId(string abroadInvestmentRelationId)
        {
            return new SuccessDataResult<AbroadInvestmentRelation>(_abroadInvestmentRelationDal.Get(ar => ar.AbroadInvestorId == abroadInvestmentRelationId));
        }

        public IResult Update(AbroadInvestmentRelation abroadInvestmentRelation)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfAbroadInvestmentRelationExitis(string abroadInvestmentRelationId)
{
            var result = _abroadInvestmentRelationDal.GetAll(ar => ar.AbroadInvestorId == abroadInvestmentRelationId).Count;
            if (result <= 0)
            {
                return new ErrorResult(Messages.InvestmentRelationsError); //mesajı düzelt
            }
            return new SuccessResult();


        }
    }
}
