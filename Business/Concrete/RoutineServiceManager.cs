using Business.Abstract;
using Business.Constans;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Meetings;
using System.Collections.Generic;


namespace Business.Concrete
{
    public class RoutineServiceManager : IRoutineServiceService
    {

        private readonly IRoutineServiceDal _routineServiceDal;

        public RoutineServiceManager(IRoutineServiceDal routineServicesDal)
        {
            _routineServiceDal = routineServicesDal;
        }

        public IDataResult<List<RoutineService>> GetAll()
        {
            return new SuccessDataResult<List<RoutineService>>(_routineServiceDal.GetAll(), Messages.RoutineServicesListed); //parantez içini araştır

        }

        public IDataResult<List<RoutineService>> GetAllByRoutineServiceId(string id)
        {
            return new SuccessDataResult<List<RoutineService>>(_routineServiceDal.GetAll(r => r.RoutineServiceId == id));
        }

        public IDataResult<RoutineService> GetByRoutineServiceId(string routineServiceId)
        {
            return new SuccessDataResult<RoutineService>(_routineServiceDal.Get(r => r.RoutineServiceId == routineServiceId));
        }

        public IDataResult<RoutineService> GetByOfficer(string officer)
        {
            return new SuccessDataResult<RoutineService>(_routineServiceDal.Get(r => r.Officer == officer));
        }

    
        public IResult Update(RoutineService routineService)
        {
            _routineServiceDal.Update(routineService);
            return new SuccessResult(Messages.SuccesResult);
        }

        public IResult Add(RoutineService routineServices)
        {
            _routineServiceDal.Add(routineServices);
            return new SuccessResult(Messages.SuccesResult);
        }


        public IResult Delete(RoutineService routineService)
        {
            _routineServiceDal.Delete(routineService);
            return new SuccessDataResult<List<RoutineService>>(Messages.Deleted);

        }

    }
}
