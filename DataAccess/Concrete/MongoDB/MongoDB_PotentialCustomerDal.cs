using Core.DataAccess.Databases.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_PotentialCustomerDal: MongoDB_RepositoryBase<PotentialCustomer, MongoDB_Context<PotentialCustomer, MongoDB_PotentialCustomerCollection>>, IPotentialCustomerDal
    {
    }
}
