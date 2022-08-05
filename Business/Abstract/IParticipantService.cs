using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IParticipantService
    {
        IDataResult<List<Participant>> GetAll();

        IDataResult<Participant> GetByParticipantId(string id);
        IResult Add(Participant participant);
        IResult Update(Participant participant);
        IResult Delete(Participant participant);
    }
}
