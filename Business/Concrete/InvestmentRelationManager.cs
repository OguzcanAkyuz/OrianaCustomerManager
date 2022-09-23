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
        private readonly IInvestmentRelationDal _investmentRelationDal;

        public InvestmentRelationManager(IInvestmentRelationDal investmentRelationDal)
        {
            _investmentRelationDal = investmentRelationDal;
        }
        [SecuredOperation("suser,admin,Customer.Add")]
        public IResult Add(InvestmentRelation investmentRelation)
        {

            _investmentRelationDal.Add(investmentRelation);
            return new SuccessResult(Messages.InvestmentRelationsSuccess);
        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<InvestmentRelation>> GetAll()
        {
            return new SuccessDataResult<List<InvestmentRelation>>(_investmentRelationDal.GetAll(), Messages.InvestmentRelationsListed);

        }

        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<InvestmentRelation>> GetAllByInvestmentRelationId(string Id)
        {
            return new SuccessDataResult<List<InvestmentRelation>>(_investmentRelationDal.GetAll(ır => ır.Id == Id));
        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<InvestmentRelation> GetByInvestmentRelationId(string investmentRelationId)
        {
            return new SuccessDataResult<InvestmentRelation>(_investmentRelationDal.Get(ır => ır.Id == investmentRelationId));
        }
        [SecuredOperation("suser,admin,Customer.Update")]
        public IResult Update(InvestmentRelation investmentRelation)
        {
         
            _investmentRelationDal.Update(investmentRelation);
            return new SuccessResult(Messages.Update);
        }
        [SecuredOperation("suser,admin,Customer.Delete")]
        public IResult Delete(string investmentRelationId)
        {
            var investmentRelation = _investmentRelationDal.Get(i => i.Id == investmentRelationId);
            _investmentRelationDal.Delete(investmentRelation);
            return new SuccessDataResult<List<InvestmentRelation>>(Messages.Deleted);
        }




        }

    }


