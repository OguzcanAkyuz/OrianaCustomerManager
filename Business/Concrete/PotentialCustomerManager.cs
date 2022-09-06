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
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<PotentialCustomer>> GetAll()
        {
           return new SuccessDataResult<List<PotentialCustomer>>(_potentialCustomer.GetAll(),Messages.PotentialCustomersList);
        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<PotentialCustomer>> GetAllByPotentialCustomerId(string Id)
        {
            return new SuccessDataResult<List<PotentialCustomer>>(_potentialCustomer.GetAll(pc => pc.Id == Id));
        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<PotentialCustomer> GetByPotentialCustomerId(string potentialCustomerId)
        {
            return new SuccessDataResult<PotentialCustomer>(_potentialCustomer.Get(pc => pc.Id == potentialCustomerId));
        }
        [SecuredOperation("suser,admin,Customer.Add")]
        public IResult Add(PotentialCustomer potentialCustomer)
        {
           
            _potentialCustomer.Add(potentialCustomer);
            return new SuccessResult(Messages.CustomerAdded);


        }
        [SecuredOperation("suser,admin,Customer.Delete")]
        public IResult Delete(PotentialCustomer potentialCustomer)
        {
            _potentialCustomer.Update(potentialCustomer);
            return new SuccessResult(Messages.Deleted);
        }
        [SecuredOperation("suser,admin,Customer.Update")]
        public IResult Update(PotentialCustomer potentialCustomer)
        {
            _potentialCustomer.Update(potentialCustomer);
            return new SuccessDataResult<List<PotentialCustomer>>(Messages.Update);
        }

   
    }
}
