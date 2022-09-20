using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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
        [SecuredOperation("suser,admin,CuriousCustomer.Add")]
        public IResult Add(CuriousCustomer curiousCustomer)
        {

            _curiousCustomerDal.Add(curiousCustomer);

            return new SuccessResult(Messages.CustomerAdded);

        }

        [SecuredOperation("suser,admin,CuriousCustomer.Get")]
        public IDataResult<List<CuriousCustomer>> GetAll()
        {
            return new SuccessDataResult<List<CuriousCustomer>>(_curiousCustomerDal.GetAll(), Messages.CuriousCustomerListed);
        }
        [SecuredOperation("suser,admin,CuriousCustomer.Get")]
        public IDataResult<List<CuriousCustomer>> GetAllByCuriousProductId(string productId)
        {
            return new SuccessDataResult<List<CuriousCustomer>>(_curiousCustomerDal.GetAll(cp => cp.Id == productId));
        }
        [SecuredOperation("suser,admin,CuriousCustomer.Get")]
        public IDataResult<CuriousCustomer> GetByCuriousCustomerId(string curiousCustomerId)
        {
            return new SuccessDataResult<CuriousCustomer>(_curiousCustomerDal.Get(cp => cp.Id == curiousCustomerId));
        }
        [SecuredOperation("suser,admin,CuriousCustomer.Delete")]
        public IResult Delete(string curiousCustomerId)
        {
            var curiousCustomer = _curiousCustomerDal.Get(c => c.Id == curiousCustomerId);
            _curiousCustomerDal.Delete(curiousCustomer);
            return new SuccessDataResult<List<CuriousCustomer>>(Messages.Deleted);
        }
        [SecuredOperation("suser,admin,CuriousCustomer.Update")]
        public IResult Update(string curiousCustomerId)
        {
            var curiousCustomer = _curiousCustomerDal.Get(c => c.Id == curiousCustomerId);
            _curiousCustomerDal.Update(curiousCustomer);
            return new SuccessResult(Messages.Update);
        }



    }
}

