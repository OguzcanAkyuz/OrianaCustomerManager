using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IInvestmentRelationService
    {

        IDataResult<List<InvestmentRelation>> GetAll();
        IDataResult<List<InvestmentRelation>> GetAllByInvestmentRelationId(string Id);
        IDataResult<InvestmentRelation> GetByInvestmentRelationId(string ınvestmentRelationId);


        IResult Add(InvestmentRelation ınvestmentRelation);
        IResult Update(InvestmentRelation ınvestmentRelation);
        IResult Delete(InvestmentRelation ınvestmentRelation);
    }
}
