using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Absract
{
    public interface ICuriousCustomersService
    {

        IDataResult<List<CuriousCustomer>> GetAll();
        IDataResult<List<CuriousCustomer>> GetAllByCuriousProductId(int productId);
        IDataResult<List<CuriousCustomer>> GetByCuriousCustomerId(int curiousCustomerId);


        IResult Add(CuriousCustomer curiousCustomers);
        IResult Update(CuriousCustomer curiousCustomers);
        IResult Delete(CuriousCustomer curiousCustomers);

    }
}
