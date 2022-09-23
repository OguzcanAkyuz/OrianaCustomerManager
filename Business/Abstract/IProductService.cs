using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetByProductId(string id);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(string id);
    }
}
