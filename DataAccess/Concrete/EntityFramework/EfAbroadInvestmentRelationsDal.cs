using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAbroadInvestmentRelationsDal : EfEntityRepositoryBase <AbroadInvestmentRelations , CustomerManagerContext  >,IAbroadInvestmentRelationsDal
    {
    }
}
