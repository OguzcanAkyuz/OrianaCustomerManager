using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Absract
{
    public interface IInvestmentRelationsService
    {

        IDataResult<List<InvestmentRelations>> GetAll();
        IDataResult<List<InvestmentRelations>> GetAllByInvestmentRelationsId(int Id);
        IDataResult<InvestmentRelations> GetByInvestmentRelationsId(int ınvestmentRelationsId);


        IResult Add(InvestmentRelations ınvestmentRelations);
        IResult Update(InvestmentRelations ınvestmentRelations);
        IResult Delete(InvestmentRelations ınvestmentRelations);
    }
}
