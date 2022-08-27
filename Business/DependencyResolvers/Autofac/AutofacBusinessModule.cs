using Autofac;
using Autofac.Core;
using Business.Abstract;
using Business.Abstract.MeetingsService;
using Business.Concrete;
using Business.Concrete.MeetingsManager;
using Core.CrossCuttingConcerns.EMailService;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Abstract.IMeetingsDal;
using DataAccess.Concrete.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;

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

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
           
            
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
            builder.RegisterType<EMailManager>().As<IEMailManager>().SingleInstance();

            builder.RegisterType<MongoDB_UserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<MongoDB_UserOperationClaimsDal>().As<IUserOperationClaimDal>().SingleInstance();
            builder.RegisterType<MongoDB_OperationClaimsDal>().As<IOperationClaimDal>().SingleInstance();










        }

    }
}
