using Business.Absract;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CustomersManager : ICustomersService
    {
        ICustomersDal _customersDal;


        public CustomersManager(ICustomersDal customersDal)
        {
            _customersDal = customersDal;
        }

        public IResult Add(Customers customers)
        {
            IResult result = BusinessRules.Run(CheckIfCustomerIdExitis(customers.CustomerId));

            if (result != null)
            {
                return new ErrorResult("Id Kısmı Boş Olamaz.");
            }
            _customersDal.Add(customers);

            return new SuccessResult(Messages.CustomerAdded);


        }
        public IDataResult<Customers> GetByCustomerId(int customerId) //iş kuralı ekle IResult.
        {
            return new SuccessDataResult<Customers>(_customersDal.Get(c => c.CustomerId == customerId));
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customersDal.GetAll(), Messages.CustomersListed);

        }

        public IDataResult<List<Customers>> GetAllByCustomersId(int id)
        {
            return new SuccessDataResult<List<Customers>>(_customersDal.GetAll(c => c.CustomerId == id));
        }

        public IDataResult<List<Customers>> GetAllCompanyBusinessArea(string companyBusinessArea)
        {
            return new SuccessDataResult<List<Customers>>(_customersDal.GetAll(), Messages.CompanyBusinessArea);
        }

        public IDataResult<List<Customers>> GetAllPurchasePrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Customers>>(_customersDal.GetAll(c => c.PurchasePrice >= min && c.PurchasePrice <= max));
        }

        private IResult CheckIfCustomerIdExitis(int customerId)
        {
            var result = _customersDal.GetAll(c => c.CustomerId == customerId).Count;
            if (result <= 0)
            {
                return new ErrorResult(Messages.CustomerIdError);

            }
            return new SuccessResult();



        }
        public IResult Delete(Customers customers)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customers customers)
        {
            throw new NotImplementedException();
        }
    }
}
