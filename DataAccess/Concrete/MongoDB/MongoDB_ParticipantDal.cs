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
    public class MongoDB_ParticipantDal : MongoDB_RepositoryBase<Participant, MongoDB_Context<Participant, MongoDB_CustomerCollection>>, IParticipantDal
    {
    }
}
