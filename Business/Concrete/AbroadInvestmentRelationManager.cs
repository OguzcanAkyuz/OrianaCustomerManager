using Business.Abstract;
using Business.Constans;
using Castle.Core.Resource;
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
        private readonly IAbroadInvestmentRelationDal _abroadInvestmentRelationDal;

        public AbroadInvestmentRelationManager(IAbroadInvestmentRelationDal abroadInvestmentRelationDal)
        {
            _abroadInvestmentRelationDal = abroadInvestmentRelationDal;

        }

        public IResult Add(AbroadInvestmentRelation abroadInvestmentRelations)
        {
            _abroadInvestmentRelationDal.Add(abroadInvestmentRelations);

            return new SuccessResult(Messages.SuccesResult);
        }

           

            public IDataResult<List<AbroadInvestmentRelation>> GetAll()
            {
                return new SuccessDataResult<List<AbroadInvestmentRelation>>(_abroadInvestmentRelationDal.GetAll(), Messages.InvestmentRelationsListed); //mesajı düzelt
            }


            public IDataResult<AbroadInvestmentRelation> GetByAbroadInvestmentRelationsId(string abroadInvestmentRelationId)
            {
                return new SuccessDataResult<AbroadInvestmentRelation>(_abroadInvestmentRelationDal.Get(ar => ar.Id == abroadInvestmentRelationId));
            }


        public IResult Delete(AbroadInvestmentRelation abroadInvestmentRelation)
        {
            _abroadInvestmentRelationDal.Delete(abroadInvestmentRelation);
            return new SuccessResult(Messages.Deleted);
        }


        public IResult Update(AbroadInvestmentRelation abroadInvestmentRelation)
            {
            _abroadInvestmentRelationDal.Update(abroadInvestmentRelation);
            return new SuccessResult(Messages.Update);
        }




        }

    }


