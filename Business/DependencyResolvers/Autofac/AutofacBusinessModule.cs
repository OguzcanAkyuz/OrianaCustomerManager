//using Autofac;
//using DataAccess.Abstract;
//using Entities.Concrete;
//using System.Reflection;

//namespace Business.DependencyResolvers
//{
//    public class AutofacBusinessModule : Module
//    {
//        protected override void Load(ContainerBuilder builder)
//        {
//            builder.RegisterType<RoutineServices>().As<IRoutineServicesDal>().SingleInstance();
//        }

//    }
//}
