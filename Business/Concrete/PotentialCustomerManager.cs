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
    public class PotentialCustomerManager : IPotentialCustomerService
    {
        IPotentialCustomerDal _potentialCustomer;

        public PotentialCustomerManager(IPotentialCustomerDal potentialCustomersDal)
        {
            _potentialCustomer = potentialCustomersDal;
        }

        public IDataResult<List<PotentialCustomer>> GetAll()
        {
           return new SuccessDataResult<List<PotentialCustomer>>(_potentialCustomer.GetAll(),Messages.PotentialCustomersList);
        }

        public IDataResult<List<PotentialCustomer>> GetAllByPotentialCustomerId(string Id)
        {
            return new SuccessDataResult<List<PotentialCustomer>>(_potentialCustomer.GetAll(pc => pc.Id == Id));
        }

        public IDataResult<PotentialCustomer> GetByPotentialCustomerId(string potentialCustomerId)
        {
            return new SuccessDataResult<PotentialCustomer>(_potentialCustomer.Get(pc => pc.Id == potentialCustomerId));
        }
        public IResult Add(PotentialCustomer potentialCustomer)
        {
           
            _potentialCustomer.Add(potentialCustomer);
            return new SuccessResult(Messages.CustomerAdded);


        }

        public IResult Delete(PotentialCustomer potentialCustomer)
        {
            _potentialCustomer.Update(potentialCustomer);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Update(PotentialCustomer potentialCustomer)
        {
            _potentialCustomer.Update(potentialCustomer);
            return new SuccessResult(Messages.Update);
        }

   
    }
}
