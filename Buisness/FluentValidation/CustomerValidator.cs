
using Entities.Concrete;
using FluentValidation;

namespace Buisness.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
       public CustomerValidator()
        {


          RuleFor(p=>p.Id).NotEmpty();  
          RuleFor(p=>p.CompanyName).Length(1, 250);
            
        }
     
    }
}
