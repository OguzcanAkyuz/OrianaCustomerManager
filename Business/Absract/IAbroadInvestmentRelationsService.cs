using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Absract
{
    public interface IAbroadInvestmentRelationsService
    {


        IDataResult<List<AbroadInvestmentRelations>> GetAll();
        IDataResult<List<AbroadInvestmentRelations>> GetAllAbroadInvestmentRelationsId(int curiousCustomerId);
        IDataResult<List<AbroadInvestmentRelations>> GetByAbroadInvestmentRelationsId(int curiousCustomerId);


        IResult Add(AbroadInvestmentRelations abroadInvestmentRelations);
        IResult Update(AbroadInvestmentRelations abroadInvestmentRelations);
        IResult Delete(AbroadInvestmentRelations abroadInvestmentRelations);




    }
}
