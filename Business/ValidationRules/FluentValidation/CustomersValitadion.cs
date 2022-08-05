using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomersValitador : AbstractValidator<Customer>

    {
        public CustomersValitador()
        {
            
            RuleFor(c => c.PurchasePrice).NotEmpty();


        }
    }
}
