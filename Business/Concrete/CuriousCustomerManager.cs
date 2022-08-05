using Business.Abstract;
using Business.Constans;
using Castle.Core.Resource;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CuriousCustomerManager : ICuriousCustomerService
    {
        ICuriousCustomerDal _curiousCustomerDal;

        public CuriousCustomerManager(ICuriousCustomerDal curiousCustomerDal)
        {
            _curiousCustomerDal = curiousCustomerDal;
        }

        public IResult Add(CuriousCustomer curiousCustomer)
{
            IResult result = BusinessRules.Run(CheckIfCuriousCustomerIdExitis(curiousCustomer.CuriousCustomerId));

            if (result != null)
            {
                return new ErrorResult("Id Kısmı Boş Olamaz.");
            }
            _curiousCustomerDal.Add(curiousCustomer);

            return new SuccessResult(Messages.CustomerAdded); //mesaj tanımla

        }

        public IResult Delete(CuriousCustomer curiousCustomer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CuriousCustomer>> GetAll()
        {
            return new SuccessDataResult<List<CuriousCustomer>>(_curiousCustomerDal.GetAll(), Messages.CuriousCustomerListed);
        }

        public IDataResult<List<CuriousCustomer>> GetAllByCuriousProductId(string productId)
        {
            return new SuccessDataResult<List<CuriousCustomer>>(_curiousCustomerDal.GetAll(cp => cp.ProductId == productId));
        }

        public IDataResult<CuriousCustomer> GetByCuriousCustomerId(string curiousCustomerId)
        {
            return new SuccessDataResult<CuriousCustomer>(_curiousCustomerDal.Get(cp => cp.CuriousCustomerId == curiousCustomerId));
        }

        public IResult Update(CuriousCustomer curiousCustomer)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfCuriousCustomerIdExitis(string curiousCustomerId)
        {
            var result = _curiousCustomerDal.GetAll(c => c.CuriousCustomerId == curiousCustomerId).Count;
            if (result <= 0)
            {
                return new ErrorResult(Messages.CustomerIdError); //mesaj tanımla 

            }
            return new SuccessResult();


        }
    }
}
