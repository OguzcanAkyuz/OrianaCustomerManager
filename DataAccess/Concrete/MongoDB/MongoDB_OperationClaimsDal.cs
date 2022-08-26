using Core.DataAccess.Databases.MongoDB;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Abstract.IMeetingsDal;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_OperationClaimsDal : MongoDB_RepositoryBase<OperationClaim, MongoDB_Context<OperationClaim, MongoDB_OperationClaimsCollection>>, IOperationClaimDal
    {
        public OperationClaim Id { get ; set; }

        public bool IsTransient()
        {
            return true;
        }
    }
}
