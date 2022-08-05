using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICuriousCustomerService
    {

        IDataResult<List<CuriousCustomer>> GetAll();
        IDataResult<List<CuriousCustomer>> GetAllByCuriousProductId(string productId);
        IDataResult<CuriousCustomer> GetByCuriousCustomerId(string curiousCustomerId);


        IResult Add(CuriousCustomer curiousCustomer);
        IResult Update(CuriousCustomer curiousCustomer);
        IResult Delete(CuriousCustomer curiousCustomer);

    }
}
