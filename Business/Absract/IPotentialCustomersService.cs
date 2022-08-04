using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Absract
{
    public interface IPotentialCustomersService
    {
        IDataResult<List<PotentialCustomers>> GetAll();
        IDataResult<List<PotentialCustomers>> GetAllByPotentialCustomerId(int potentialCustomerId);
        IDataResult<PotentialCustomers> GetByPotentialCustomerId(int potentialCustomerId);


        IResult Add(PotentialCustomers potentialCustomers);
        IResult Update(PotentialCustomers potentialCustomers);
        IResult Delete(PotentialCustomers potentialCustomers);





    }
}
