using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRoutineServiceService
    {

        IDataResult<List<RoutineService>> GetAll();
        IDataResult<List<RoutineService>> GetAllByRoutineServiceId(string id);
        IDataResult<RoutineService> GetByRoutineServiceId(string routineServiceId);

        IDataResult<RoutineService> GetByOfficer(string officer); 

        IResult Add(RoutineService routineServices);
        IResult Delete(string routineServicesId);
        IResult Update(RoutineService routineServices);

    }
}
