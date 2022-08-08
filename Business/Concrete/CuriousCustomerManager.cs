using Business.Abstract;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CuriousCustomerManager : ICuriousCustomerService
    {
        private readonly ICuriousCustomerDal _curiousCustomerDal;

        public CuriousCustomerManager(ICuriousCustomerDal curiousCustomerDal)
        {
            _curiousCustomerDal = curiousCustomerDal;
        }

        public IResult Add(CuriousCustomer curiousCustomer)
        {
            
            _curiousCustomerDal.Add(curiousCustomer);

            return new SuccessResult(Messages.CustomerAdded); //mesaj tanımla

        }

        

        public IDataResult<List<CuriousCustomer>> GetAll()
        {
            return new SuccessDataResult<List<CuriousCustomer>>(_curiousCustomerDal.GetAll(), Messages.CuriousCustomerListed);
        }

        public IDataResult<List<CuriousCustomer>> GetAllByCuriousProductId(string productId)
        {
            return new SuccessDataResult<List<CuriousCustomer>>(_curiousCustomerDal.GetAll(cp => cp.Id == productId));
        }

        public IDataResult<CuriousCustomer> GetByCuriousCustomerId(string curiousCustomerId)
        {
            return new SuccessDataResult<CuriousCustomer>(_curiousCustomerDal.Get(cp => cp.Id == curiousCustomerId));
        }

        public IResult Delete(CuriousCustomer curiousCustomer)
        {
            _curiousCustomerDal.Delete(curiousCustomer);
            return new SuccessResult(Messages.Deleted);
        }
        public IResult Update(CuriousCustomer curiousCustomer)
        {

            _curiousCustomerDal.Update(curiousCustomer);
            return new SuccessResult(Messages.Update);
        }



        }
    }

