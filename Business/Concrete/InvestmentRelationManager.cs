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
    public class InvestmentRelationManager : IInvestmentRelationService
    {
        IInvestmentRelationDal _ınvestmentRelationDal;

        public InvestmentRelationManager(IInvestmentRelationDal ınvestmentRelationDal)
        {
            _ınvestmentRelationDal = ınvestmentRelationDal;
        }

        public IResult Add(InvestmentRelation ınvestmentRelation)
        {
            IResult result = BusinessRules.Run(CheckIfInvestmentRelationExitis(ınvestmentRelation.InvestmentRelationId));
            if ( result!= null)
            {
                return new ErrorResult("Başarısız");       //Parantez içini değiştir.
            }
            _ınvestmentRelationDal.Add(ınvestmentRelation);
            return new SuccessResult(Messages.InvestmentRelationsSuccess);
        }

        public IDataResult<List<InvestmentRelation>> GetAll()
        {
            return new SuccessDataResult<List<InvestmentRelation>>(_ınvestmentRelationDal.GetAll(), Messages.InvestmentRelationsListed);

        }


        public IDataResult<List<InvestmentRelation>> GetAllByInvestmentRelationId(string Id)
        {
            return new SuccessDataResult<List<InvestmentRelation>>(_ınvestmentRelationDal.GetAll(ır => ır.InvestmentRelationId == Id));
        }

        public IDataResult<InvestmentRelation> GetByInvestmentRelationId(string ınvestmentRelationId)
        {
            return new SuccessDataResult<InvestmentRelation>(_ınvestmentRelationDal.Get(ır => ır.InvestmentRelationId == ınvestmentRelationId));
        }

        public IResult Update(InvestmentRelation ınvestmentRelation)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(InvestmentRelation ınvestmentRelation)
        {
            throw new NotImplementedException();
        }


        private IResult CheckIfInvestmentRelationExitis(string ınvestmentRelationId)
        {
            var result = _ınvestmentRelationDal.GetAll(ır => ır.InvestmentRelationId == ınvestmentRelationId).Count;
            if(result <= 0)
            {
                return new ErrorResult(Messages.InvestmentRelationsError);
            }
            return new SuccessResult();


        }

    }

}
