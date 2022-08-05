using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPotentialCustomerService
    {
        IDataResult<List<PotentialCustomer>> GetAll();
        IDataResult<List<PotentialCustomer>> GetAllByPotentialCustomerId(string potentialCustomerId);
        IDataResult<PotentialCustomer> GetByPotentialCustomerId(string potentialCustomerId);


        IResult Add(PotentialCustomer potentialCustomers);

        IResult Update(PotentialCustomer potentialCustomers);
        IResult Delete(PotentialCustomer potentialCustomers);





    }
}
