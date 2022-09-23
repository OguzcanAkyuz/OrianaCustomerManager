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

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;


        public CustomerManager(ICustomerDal customersDal)
        {
            _customerDal = customersDal;
        }
        [SecuredOperation("suser,admin,Customer.Update")]
        public IResult Add(Customer customer)
        {
       

            _customerDal.Add(customer);

            return new SuccessResult(Messages.CustomerAdded);


        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<Customer> GetByCustomerId(string customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == customerId));
        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);

        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<Customer>> GetAllByCustomersId(string id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.Id == id));
        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<Customer>> GetAllCompanyBusinessArea(string companyBusinessArea)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CompanyBusinessArea);
        }



        [SecuredOperation("suser,admin,Customer.Delete")]
        public IResult Delete(string customerId)
        {
            var customer = _customerDal.Get(x => x.Id == customerId);
            _customerDal.Delete(customer);
            return new SuccessDataResult<List<Customer>>(Messages.Deleted);
        }
        [SecuredOperation("suser,admin,Customer.Update")]
        public IResult Update(Customer customer)
        {
           
            _customerDal.Update(customer);

            return new SuccessDataResult<List<Customer>>(Messages.Update);
        }
    }
}
