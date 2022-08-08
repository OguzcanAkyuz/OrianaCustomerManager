using Core.DataAccess.Databases.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_CuriousCustomerDal :MongoDB_RepositoryBase<CuriousCustomer, MongoDB_Context<CuriousCustomer, MongoDB_CustomerCollection>>, ICuriousCustomerDal
    {
    }
}
