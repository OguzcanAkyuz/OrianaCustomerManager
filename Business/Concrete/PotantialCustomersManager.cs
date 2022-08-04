using Business.Absract;
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
    public class PotentialCustomersManager : IPotentialCustomersService
    {
        IPotentialCustomersDal _potentialCustomers;

        public PotentialCustomersManager(IPotentialCustomersDal potentialCustomersDal)
        {
            _potentialCustomers = potentialCustomersDal;
        }

        public IDataResult<List<PotentialCustomers>> GetAll()
        {
           return new SuccessDataResult<List<PotentialCustomers>>(_potentialCustomers.GetAll(),Messages.PotentialCustomersList);
        }

        public IDataResult<List<PotentialCustomers>> GetAllByPotentialCustomerId(int Id)
        {
            return new SuccessDataResult<List<PotentialCustomers>>(_potentialCustomers.GetAll(pc => pc.PotentialCustomersId == Id));
        }

        public IDataResult<PotentialCustomers> GetByPotentialCustomerId(int potentialCustomerId)
        {
            return new SuccessDataResult<PotentialCustomers>(_potentialCustomers.Get(pc => pc.PotentialCustomersId == potentialCustomerId));
        }
        public IResult Add(PotentialCustomers potentialCustomers)
        {
            IResult result = BusinessRules.Run(CheckIfPotentialCustomerIdExitis(potentialCustomers.PotentialCustomersId));
            if(result != null)
            {
                return new ErrorResult(Messages.PotentialCustomersError);
            
            }
            _potentialCustomers.Add(potentialCustomers);
            return new SuccessResult(Messages.CustomerAdded);


        }

        public IResult Delete(PotentialCustomers potentialCustomers)
        {
            throw new NotImplementedException();
        }

        public IResult Update(PotentialCustomers potentialCustomers)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfPotentialCustomerIdExitis(int potentialCustomerId)
        {
            var result = _potentialCustomers.GetAll(pc => pc.PotentialCustomersId == potentialCustomerId).Count;
            if(result <= 0)
            {
                return new ErrorResult(Messages.PotentialCustomersError);

            }
            return new SuccessResult();
        }
    }
}
