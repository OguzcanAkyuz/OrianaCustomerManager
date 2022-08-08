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
        private readonly ICustomerDal _customerDal;


        public CustomerManager(ICustomerDal customersDal)
        {
            _customerDal = customersDal;
        }

        public IResult Add(Customer customer)
        {
       

            _customerDal.Add(customer);

            return new SuccessResult(Messages.CustomerAdded);


        }
        public IDataResult<Customer> GetByCustomerId(string customerId) //iş kuralı ekle IResult.
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == customerId));
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);

        }

        public IDataResult<List<Customer>> GetAllByCustomersId(string id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.Id == id));
        }

        public IDataResult<List<Customer>> GetAllCompanyBusinessArea(string companyBusinessArea)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CompanyBusinessArea);
        }

        public IDataResult<List<Customer>> GetAllPurchasePrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.PurchasePrice >= min && c.PurchasePrice <= max));
        }

        
        public IResult Delete(Customer customer)
        {

            _customerDal.Delete(customer);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Update(Customer customer)
        {
          
            _customerDal.Update(customer);

            return new SuccessResult(Messages.Update);
        }
    }
}
