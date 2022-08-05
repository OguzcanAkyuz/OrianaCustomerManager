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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;


        public CustomerManager(ICustomerDal customersDal)
        {
            _customerDal = customersDal;
        }

        public IResult Add(Customer customer)
        {
            IResult result = BusinessRules.Run(CheckIfCustomerIdExitis(customer.CustomerId));

            if (result != null)
            {
                return new ErrorResult("Id Kısmı Boş Olamaz.");
            }
            _customerDal.Add(customer);

            return new SuccessResult(Messages.CustomerAdded);


        }
        public IDataResult<Customer> GetByCustomerId(string customerId) //iş kuralı ekle IResult.
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.CustomerId == customerId));
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);

        }

        public IDataResult<List<Customer>> GetAllByCustomersId(string id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.CustomerId == id));
        }

        public IDataResult<List<Customer>> GetAllCompanyBusinessArea(string companyBusinessArea)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CompanyBusinessArea);
        }

        public IDataResult<List<Customer>> GetAllPurchasePrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.PurchasePrice >= min && c.PurchasePrice <= max));
        }

        private IResult CheckIfCustomerIdExitis(string customerId)
        {
            var result = _customerDal.GetAll(c => c.CustomerId == customerId).Count;
            if (result <= 0)
            {
                return new ErrorResult(Messages.CustomerIdError);

            }
            return new SuccessResult();



        }
        public IResult Delete(Customer customers)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customer customers)
        {
            throw new NotImplementedException();
        }
    }
}
