using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomersValitador :AbstractValidator<Customer>

    {
        public CustomersValitador() {
            RuleFor(c => c.CustomerId).GreaterThan(0);
            RuleFor(c => c.PurchasePrice).NotEmpty();
       
                
        }
    }
}
