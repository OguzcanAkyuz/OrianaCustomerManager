using Abp.Domain.Entities;
using Core.DataAccess.Databases;
using Core.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserOperationClaimDal : IEntityRepository<UserOperationClaim>
    {
    }
}
