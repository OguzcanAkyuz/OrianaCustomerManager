using Business.Absract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CuriousCustomersManager : ICuriousCustomersService
    {
        ICuriousCustomersDal _curiousCustomersDal;

        public CuriousCustomersManager (ICuriousCustomersDal curiousCustomersDal)
        {
            _curiousCustomersDal = curiousCustomersDal;
        }

        public IResult Add(CuriousCustomer curiousCustomers)
        {
            throw new NotImplementedException();
        }

     

        public IDataResult<List<CuriousCustomer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CuriousCustomer>> GetAllByCuriousProductId(int productId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CuriousCustomer>> GetByCuriousCustomerId(int curiousCustomerId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CuriousCustomer curiousCustomers)
        {
            throw new NotImplementedException();
        }
        public IResult Delete(CuriousCustomer curiousCustomers)
        {
            throw new NotImplementedException();
        }
    }
}
