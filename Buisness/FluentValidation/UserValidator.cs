using Entities.Concrete;
using FluentValidation;

namespace Buisness.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator() 
        {
            RuleFor(p=>p.FirstName).NotEmpty(); 
            RuleFor(p=>p.LastName).NotEmpty();
            RuleFor(p =>p.Email).Must(EndsWithMail); 
        
        }


        private bool EndsWithMail(string arg)
        {
            return arg.EndsWith(".com");
        }
    }
    }
   

