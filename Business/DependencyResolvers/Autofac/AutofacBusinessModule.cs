using Autofac;
using Business.Abstract;
using Business.Abstract.MeetingsService;
using Business.Concrete;
using Business.Concrete.MeetingsManager;
using DataAccess.Abstract;
using DataAccess.Abstract.IMeetingsDal;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.EfMeetingsDal;
using Entities.Concrete;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
       protected override void Load(ContainerBuilder builder)
       {
            builder.RegisterType<RoutineServiceManager>().As<IRoutineServiceService>().SingleInstance();
            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();
            builder.RegisterType<EfRoutineServiceDal>().As<IRoutineServiceDal>().SingleInstance();
            builder.RegisterType<ScheduledMeetingManager >().As<IScheduledMeetingService>().SingleInstance();
            builder.RegisterType<EfScheduledMeetingDal>().As<IScheduledMeetingDal>();

           

        }

    }
}
