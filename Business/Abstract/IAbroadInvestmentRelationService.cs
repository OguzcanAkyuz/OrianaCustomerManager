using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAbroadInvestmentRelationService
    {


        IDataResult<List<AbroadInvestmentRelation>> GetAll();
        IDataResult<AbroadInvestmentRelation> GetByAbroadInvestmentRelationsId(string abroadInvestmentRelation);


        IResult Add(AbroadInvestmentRelation abroadInvestmentRelation);
        IResult Update(AbroadInvestmentRelation abroadInvestmentRelation);
        IResult Delete(AbroadInvestmentRelation abroadInvestmentRelation);




    }
}
