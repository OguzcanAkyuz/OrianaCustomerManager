using Business.Abstract;
using Business.Constans;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;


namespace Business.Concrete
{
    public class RoutineServiceManager : IRoutineServiceService
    {

        IRoutineServiceDal _routineServiceDal;

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

        [CacheRemoveAspect("IRoutineService.Get")]
        public IResult Update(RoutineService routineServices)
        {
            var result = _routineServiceDal.GetAll(r => r.RoutineServiceId == routineServices.RoutineServiceId).Count;
            if(result <= 0)
            {
                return new ErrorResult(Messages.RoutineServicesError);
            }
            return new SuccessResult("");
        }

        public IResult Add(RoutineService routineServices)
        {
            IResult result = BusinessRules.Run(CheckIfRoutineServicesExitis(routineServices.RoutineServiceId));
            if (result == null)
            {
                return new ErrorResult("Rutin Servis Id boş olamaz.");
            }
            _routineServiceDal.Add(routineServices);
            return new SuccessResult(Messages.SuccesResult);
        }

        private IResult CheckIfRoutineServicesExitis(string routineServiceId)
        {
            var result = _routineServiceDal.GetAll(r => r.RoutineServiceId == routineServiceId).Count;
            if (result > 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult(Messages.CustomerIdError);
        }

        public IResult Delete(string routineServicesId)
        {
            throw new System.NotImplementedException();
        }

    }
}
