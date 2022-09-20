using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Meetings;
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
        [SecuredOperation("suser,admin,Customer.Add")]
        public IResult Add(Product product)
        {
          
            _productDal.Add(product);
            return new SuccessResult(Messages.SuccesResult);

        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<Product> GetByProductId(string id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == id));
        }

        [SecuredOperation("suser,admin,Customer.Update")]
        public IResult Update(string productId)
        {
            var product = _productDal.Get(p => p.Id == productId);
            _productDal.Update(product);
            return new SuccessResult(Messages.Update);
        }
        [SecuredOperation("suser,admin,Customer.Delete")]
        public IResult Delete(string productId)
        {
            var product = _productDal.Get(p => p.Id == productId);
            _productDal.Delete(product);
            return new SuccessDataResult<List<Product>>(Messages.Deleted);
        }

    }
}
