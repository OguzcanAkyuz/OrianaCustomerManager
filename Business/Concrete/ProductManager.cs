using Business.Abstract;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
      private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(Product product)
        {
          
            _productDal.Add(product);
            return new SuccessResult(Messages.SuccesResult);

        }
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<Product> GetByProductId(string id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == id));
        }

   
        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.Update);
        }
        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.Deleted);
        }

    }
}
