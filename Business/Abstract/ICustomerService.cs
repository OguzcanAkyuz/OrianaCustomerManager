using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        //müşterilerin iş alanlarını çek 

        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetAllByCustomersId(string id);
        IDataResult<List<Customer>> GetAllPurchasePrice(decimal min, decimal max);
        IDataResult<List<Customer>> GetAllCompanyBusinessArea(string companyBusinessArea);
        IDataResult<Customer> GetByCustomerId(string customerId);
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
    }
}
