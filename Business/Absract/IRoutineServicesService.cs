using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Absract
{
    public interface IRoutineServicesService
    {

        IDataResult<List<RoutineServices>> GetAll();
        IDataResult<List<RoutineServices>> GetAllByRoutineServicesId(int id);
        IDataResult<RoutineServices> GetByRoutineServiceId(int routineServiceId);

        IDataResult<RoutineServices> GetByOfficer(string officer); 

        IResult Add(RoutineServices routineServices);
        IResult Delete(int routineServicesId);
        IResult Update(RoutineServices routineServices);

    }
}
