using Business.Abstract;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PotentialCustomersManager : IPotentialCustomerService
    {
        IPotentialCustomerDal _potentialCustomer;

        public PotentialCustomersManager(IPotentialCustomerDal potentialCustomersDal)
        {
            _potentialCustomer = potentialCustomersDal;
        }

        public IDataResult<List<PotentialCustomer>> GetAll()
        {
           return new SuccessDataResult<List<PotentialCustomer>>(_potentialCustomer.GetAll(),Messages.PotentialCustomersList);
        }

        public IDataResult<List<PotentialCustomer>> GetAllByPotentialCustomerId(string Id)
        {
            return new SuccessDataResult<List<PotentialCustomer>>(_potentialCustomer.GetAll(pc => pc.PotentialCustomerId == Id));
        }

        public IDataResult<PotentialCustomer> GetByPotentialCustomerId(string potentialCustomerId)
        {
            return new SuccessDataResult<PotentialCustomer>(_potentialCustomer.Get(pc => pc.PotentialCustomerId == potentialCustomerId));
        }
        public IResult Add(PotentialCustomer potentialCustomers)
        {
            IResult result = BusinessRules.Run(CheckIfPotentialCustomerIdExitis(potentialCustomers.PotentialCustomerId));
            if(result != null)
            {
                return new ErrorResult(Messages.PotentialCustomersError);
            
            }
            _potentialCustomer.Add(potentialCustomers);
            return new SuccessResult(Messages.CustomerAdded);


        }

        public IResult Delete(PotentialCustomer potentialCustomers)
        {
            throw new NotImplementedException();
        }

        public IResult Update(PotentialCustomer potentialCustomers)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfPotentialCustomerIdExitis(string potentialCustomerId)
        {
            var result = _potentialCustomer.GetAll(pc => pc.PotentialCustomerId == potentialCustomerId).Count;
            if(result <= 0)
            {
                return new ErrorResult(Messages.PotentialCustomersError);

            }
            return new SuccessResult();
        }
    }
}
