using Business.Absract;
using Business.Constans;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;


namespace Business.Concrete
{
    public class RoutineServicesManager : IRoutineServicesService
    {

        IRoutineServicesDal _routineServicesDal;

        public RoutineServicesManager(IRoutineServicesDal routineServicesDal)
        {
            _routineServicesDal = routineServicesDal;
        }

        public IDataResult<List<RoutineService>> GetAll()
        {
            return new SuccessDataResult<List<RoutineService>>(_routineServicesDal.GetAll(), Messages.RoutineServicesListed); //parantez içini araştır

        }

        public IDataResult<List<RoutineService>> GetAllByRoutineServicesId(int id)
        {
            return new SuccessDataResult<List<RoutineService>>(_routineServicesDal.GetAll(r => r.RoutineServicesId == id));
        }

        public IDataResult<RoutineService> GetByRoutineServiceId(int routineServiceId)
        {
            return new SuccessDataResult<RoutineService>(_routineServicesDal.Get(r => r.RoutineServicesId == routineServiceId));
        }

        public IDataResult<RoutineService> GetByOfficer(string officer)
        {
            return new SuccessDataResult<RoutineService>(_routineServicesDal.GetAll(r => r.Officer == officer));
        }

        [CacheRemoveAspect("IRoutineService.Get")]
        public IResult Update(RoutineService routineServices)
        {
            var result = _routineServicesDal.GetAll(r => r.RoutineServicesId == routineServices.RoutineServicesId).Count;
            if(result <= 0)
            {
                return new ErrorResult(Messages.RoutineServicesError);
            }
            return new SuccessResult("");
        }

        public IResult Add(RoutineService routineServices)
        {
            IResult result = BusinessRules.Run(CheckIfRoutineServicesExitis(routineServices.RoutineServicesId));
            if (result == null)
            {
                return new ErrorResult("Rutin Servis Id boş olamaz.");
            }
            _routineServicesDal.Add(routineServices);
            return new SuccessResult(Messages.SuccesResult);
        }

        private IResult CheckIfRoutineServicesExitis(int routineServicesId)
        {
            var result = _routineServicesDal.GetAll(r => r.RoutineServicesId == routineServicesId).Count;
            if (result > 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult(Messages.CustomerIdError);
        }

        public IResult Delete(int routineServicesId)
        {
            throw new System.NotImplementedException();
        }

    }
}
