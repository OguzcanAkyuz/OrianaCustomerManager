using Autofac;
using Business.Abstract;
using Business.Abstract.MeetingsService;
using Business.Concrete;
using Business.Concrete.MeetingsManager;
using DataAccess.Abstract;
using DataAccess.Abstract.IMeetingsDal;
using DataAccess.Concrete.MongoDB;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<AbroadInvestmentRelationManager>().As<IAbroadInvestmentRelationService>().SingleInstance();
            builder.RegisterType<RoutineServiceManager>().As<IRoutineServiceService>().SingleInstance();
            builder.RegisterType<ScheduledMeetingManager>().As<IScheduledMeetingService>().SingleInstance();
            builder.RegisterType<FinishedMeetingManager>().As<IFinishedMeetingService>().SingleInstance();
            builder.RegisterType<PotentialCustomerManager>().As<IPotentialCustomerService>().SingleInstance();
            builder.RegisterType<ParticipantManager>().As<IParticipantService>().SingleInstance();
            builder.RegisterType<InvestmentRelationManager>().As<IInvestmentRelationService>().SingleInstance();
            builder.RegisterType<CuriousCustomerManager>().As<ICuriousCustomerService>().SingleInstance();
            //*****************************
            builder.RegisterType<MongoDB_CustomersDal>().As<ICustomerDal>().SingleInstance();
            builder.RegisterType<MongoDB_ProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<MongoDB_AbroadInvestmentRelationDal>().As<IAbroadInvestmentRelationDal>().SingleInstance();
            builder.RegisterType<MongoDB_RoutineServiceDal>().As<IRoutineServiceDal>().SingleInstance();
            builder.RegisterType<MongoDB_ScheduledMeetingDal>().As<IScheduledMeetingDal>().SingleInstance();
            builder.RegisterType<MongoDB_FinishedMeetingDal>().As<IFinishedMeetingDal>().SingleInstance();
            builder.RegisterType<MongoDB_PotentialCustomerDal>().As<IPotentialCustomerDal>().SingleInstance();
            builder.RegisterType<MongoDB_ParticipantDal>().As<IParticipantDal>().SingleInstance();
            builder.RegisterType<MongoDB_InvestmentRelationDal>().As<IInvestmentRelationDal>().SingleInstance();
            builder.RegisterType<MongoDB_CuriousCustomerDal>().As<ICuriousCustomerDal>().SingleInstance();











        }

    }
}
