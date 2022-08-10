using Business.Abstract;
using Business.Constans;
using Castle.Core.Resource;
using Core.CrossCuttingConcerns.EMailService;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AbroadInvestmentRelationManager : IAbroadInvestmentRelationService
    {
        private readonly IAbroadInvestmentRelationDal _abroadInvestmentRelationDal;
        private readonly IEMailManager _iEMailManager;
        public AbroadInvestmentRelationManager(IAbroadInvestmentRelationDal abroadInvestmentRelationDal,IEMailManager iEMailManager)
        {
            _iEMailManager = iEMailManager;
            _abroadInvestmentRelationDal = abroadInvestmentRelationDal;

        }

        public IResult Add(AbroadInvestmentRelation abroadInvestmentRelations)
        {
            _abroadInvestmentRelationDal.Add(abroadInvestmentRelations);

            return new SuccessResult(Messages.SuccesResult);
        }

           

            public IDataResult<List<AbroadInvestmentRelation>> GetAll()
            {
            var toList = new List<string>();
            toList.Add("halit.ozer@ozztech.net");
            _iEMailManager.SendEMail(
                new Core.Entities.Concrete.EMailConfig {EnableSsl=true,From = "ouzcustomermanager@hotmail.com", Password= "ouzoztek1!", Port= 587, SmtpServer = "smtp-mail.outlook.com", To=toList }, 
                new Core.Entities.Concrete.EMailContent {Body = "hotmailde oluyor ",IsBodyHtml = true,Subject = "Mail Test" });

                return new SuccessDataResult<List<AbroadInvestmentRelation>>(_abroadInvestmentRelationDal.GetAll(), Messages.InvestmentRelationsListed); //mesajı düzelt
            }


            public IDataResult<AbroadInvestmentRelation> GetByAbroadInvestmentRelationsId(string abroadInvestmentRelationId)
            {
                return new SuccessDataResult<AbroadInvestmentRelation>(_abroadInvestmentRelationDal.Get(ar => ar.Id == abroadInvestmentRelationId));
            }


        public IResult Delete(AbroadInvestmentRelation abroadInvestmentRelation)
        {
            _abroadInvestmentRelationDal.Delete(abroadInvestmentRelation);
            return new SuccessResult(Messages.Deleted);
        }


        public IResult Update(AbroadInvestmentRelation abroadInvestmentRelation)
            {
            _abroadInvestmentRelationDal.Update(abroadInvestmentRelation);
            return new SuccessResult(Messages.Update);
        }




        }

    }


