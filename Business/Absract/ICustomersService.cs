using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Absract
{
    public interface ICustomersService
    {
        //müşterilerin iş alanlarını çek 

        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetAllByCustomersId(int id);
        IDataResult<List<Customer>> GetAllPurchasePrice(decimal min, decimal max);
        IDataResult<List<Customer>> GetAllCompanyBusinessArea(string companyBusinessArea);
        IDataResult<Customer> GetByCustomerId(int customerId);
        IResult Add(Customer customers);
        IResult Update(Customer customers);
        IResult Delete(Customer customers);
    }
}
