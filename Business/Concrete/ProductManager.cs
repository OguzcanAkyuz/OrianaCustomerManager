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
        IProductDal _productDal;
        public IResult Add(Product product)
        {
            IResult result = BusinessRules.Run(CheckIfProductIdExitis(product.ProductId));
            if(result == null)
            {
                return new ErrorResult("Doldur Burayı ");
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.SuccesResult);

        }

       
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<Product> GetByProductId(string id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == id));
        }

        private IResult CheckIfProductIdExitis(string productId)
        {
            var result = _productDal.GetAll(p => p.ProductId == productId).Count;
            if (result <= 0)
            {
                return new ErrorResult(Messages.ProductError);
            }
            return new SuccessResult();
        }
        public IResult Update(Product product)
        {
            throw new NotImplementedException();
        }
        public IResult Delete(Product product)
        {
            throw new NotImplementedException();
        }

    }
}
