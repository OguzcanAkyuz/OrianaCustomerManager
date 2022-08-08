using Core.DataAccess.Databases.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_AbroadInvestmentRelationDal : MongoDB_RepositoryBase<AbroadInvestmentRelation, MongoDB_Context<AbroadInvestmentRelation, MongoDB_AbroadInvestmentRelationCollection>> , IAbroadInvestmentRelationDal 
    {
    }
}
