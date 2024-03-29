﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPotentialCustomerService
    {
        IDataResult<List<PotentialCustomer>> GetAll();
       
        IDataResult<PotentialCustomer> GetByPotentialCustomerId(string potentialCustomerId);


        IResult Add(PotentialCustomer potentialCustomer);

        IResult Update(PotentialCustomer potentialCustomer);
        IResult Delete(string id);





    }
}
