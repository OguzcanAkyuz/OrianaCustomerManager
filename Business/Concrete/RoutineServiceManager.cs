using Business.Abstract;
using Business.BusinessAspects.Autofac;
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
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<RoutineService>> GetAll()
        {
            return new SuccessDataResult<List<RoutineService>>(_routineServiceDal.GetAll(), Messages.RoutineServicesListed); //parantez içini araştır

        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<List<RoutineService>> GetAllByRoutineServiceId(string id)
        {
            return new SuccessDataResult<List<RoutineService>>(_routineServiceDal.GetAll(r => r.Id == id));
        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<RoutineService> GetByRoutineServiceId(string routineServiceId)
        {
            return new SuccessDataResult<RoutineService>(_routineServiceDal.Get(r => r.Id == routineServiceId));
        }
        [SecuredOperation("suser,admin,Customer.Get")]
        public IDataResult<RoutineService> GetByOfficer(string officer)
        {
            return new SuccessDataResult<RoutineService>(_routineServiceDal.Get(r => r.Officer == officer));
        }

        [SecuredOperation("suser,admin,Customer.Update")]
        public IResult Update(RoutineService routineService)
        {
            _routineServiceDal.Update(routineService);
            return new SuccessResult(Messages.SuccesResult);
        }
        [SecuredOperation("suser,admin,Customer.Add")]
        public IResult Add(RoutineService routineServices)
        {
            _routineServiceDal.Add(routineServices);
            return new SuccessResult(Messages.SuccesResult);
        }

        [SecuredOperation("suser,admin,Customer.Delete")]
        public IResult Delete(RoutineService routineService)
        {
            _routineServiceDal.Delete(routineService);
            return new SuccessDataResult<List<RoutineService>>(Messages.Deleted);

        }

    }
}
