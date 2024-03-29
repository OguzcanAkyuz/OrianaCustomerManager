﻿using Core.DataAccess.Databases;
using Entities.Concrete.Meetings;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract.IMeetingsDal
{
    public  interface IFinishedMeetingDal : IEntityRepository<FinishedMeeting>
    {
    }
}
