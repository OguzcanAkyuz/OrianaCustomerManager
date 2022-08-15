using Core.DataAccess.Databases.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_CustomersDal : MongoDB_RepositoryBase<Customer, MongoDB_Context<Customer, MongoDB_CustomerCollection>>, ICustomerDal
    {
    }
}
