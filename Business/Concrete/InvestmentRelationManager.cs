using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class InvestmentRelationManager : IInvestmentRelationService
    {
        private readonly IInvestmentRelationDal _ınvestmentRelationDal;

        public InvestmentRelationManager(IInvestmentRelationDal ınvestmentRelationDal)
        {
            _ınvestmentRelationDal = ınvestmentRelationDal;
        }
        [SecuredOperation("suser,admin,Customer.Add")]
        public IResult Add(InvestmentRelation ınvestmentRelation)
        {
           
            _ınvestmentRelationDal.Add(ınvestmentRelation);
            return new SuccessResult(Messages.InvestmentRelationsSuccess);
        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<InvestmentRelation>> GetAll()
        {
            return new SuccessDataResult<List<InvestmentRelation>>(_ınvestmentRelationDal.GetAll(), Messages.InvestmentRelationsListed);

        }

        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<InvestmentRelation>> GetAllByInvestmentRelationId(string Id)
        {
            return new SuccessDataResult<List<InvestmentRelation>>(_ınvestmentRelationDal.GetAll(ır => ır.Id == Id));
        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<InvestmentRelation> GetByInvestmentRelationId(string ınvestmentRelationId)
        {
            return new SuccessDataResult<InvestmentRelation>(_ınvestmentRelationDal.Get(ır => ır.Id == ınvestmentRelationId));
        }
        [SecuredOperation("suser,admin,Customer.Update")]
        public IResult Update(InvestmentRelation ınvestmentRelation)
        {
            _ınvestmentRelationDal.Update(ınvestmentRelation);
            return new SuccessResult(Messages.Update);
        }
        [SecuredOperation("suser,admin,Customer.Delete")]
        public IResult Delete(InvestmentRelation ınvestmentRelation)
        {
            _ınvestmentRelationDal.Delete(ınvestmentRelation);
            return new SuccessDataResult<List<InvestmentRelation>>(Messages.Deleted);
        }




        }

    }


