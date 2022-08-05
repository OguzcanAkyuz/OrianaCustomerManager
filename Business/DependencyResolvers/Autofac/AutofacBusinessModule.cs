using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

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
        }

    }
}
