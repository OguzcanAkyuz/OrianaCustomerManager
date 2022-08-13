using Business.Abstract;
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

        public IResult Add(InvestmentRelation ınvestmentRelation)
        {
           
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
            _ınvestmentRelationDal.Update(ınvestmentRelation);
            return new SuccessResult(Messages.Update);
        }

        public IResult Delete(InvestmentRelation ınvestmentRelation)
        {
            _ınvestmentRelationDal.Delete(ınvestmentRelation);
            return new SuccessDataResult<List<InvestmentRelation>>(Messages.Deleted);
        }




        }

    }


