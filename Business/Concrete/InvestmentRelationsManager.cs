using Business.Absract;
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
    public class InvestmentRelationsManager : IInvestmentRelationsService
    {
        IInvestmentRelationsDal _ınvestmentRelationsDal;

        public InvestmentRelationsManager(IInvestmentRelationsDal ınvestmentRelationsDal)
        {
            _ınvestmentRelationsDal = ınvestmentRelationsDal;
        }

        public IResult Add(InvestmentRelations ınvestmentRelations)
        {
            IResult result = BusinessRules.Run(CheckIfInvestmentRelationsExitis(ınvestmentRelations.InvestmentRelationsId));
            if ( result!= null)
            {
                return new ErrorResult("Başarısız");       //Parantez içini değiştir.
            }
            _ınvestmentRelationsDal.Add(ınvestmentRelations);
            return new SuccessResult(Messages.InvestmentRelationsSuccess);
        }

        public IDataResult<List<InvestmentRelations>> GetAll()
        {
            return new SuccessDataResult<List<InvestmentRelations>>(_ınvestmentRelationsDal.GetAll(), Messages.InvestmentRelationsListed);

        }


        public IDataResult<List<InvestmentRelations>> GetAllByInvestmentRelationsId(int Id)
        {
            return new SuccessDataResult<List<InvestmentRelations>>(_ınvestmentRelationsDal.GetAll(ır => ır.InvestmentRelationsId == Id));
        }

        public IDataResult<InvestmentRelations> GetByInvestmentRelationsId(int ınvestmentRelationsId)
        {
            return new SuccessDataResult<InvestmentRelations>(_ınvestmentRelationsDal.Get(ır => ır.InvestmentRelationsId == ınvestmentRelationsId));
        }

        public IResult Update(InvestmentRelations ınvestmentRelations)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(InvestmentRelations ınvestmentRelations)
        {
            throw new NotImplementedException();
        }


        private IResult CheckIfInvestmentRelationsExitis(int ınvestmentRelationsId)
        {
            var result = _ınvestmentRelationsDal.GetAll(ır => ır.InvestmentRelationsId == ınvestmentRelationsId).Count;
            if(result <= 0)
            {
                return new ErrorResult(Messages.InvestmentRelationsError);
            }
            return new SuccessResult();


        }

    }

}
