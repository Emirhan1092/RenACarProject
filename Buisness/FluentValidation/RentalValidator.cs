
using Entities.Concrete;
using FluentValidation;

namespace Buisness.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {

        public RentalValidator()
        {
            RuleFor(p => p.RentalId).NotEmpty();
            RuleFor(p => p.CarId).NotEmpty();
            RuleFor(p => p.CustomerId).NotEmpty();
            RuleFor(p => p.RentDate).NotEmpty();  



        }



    }
}


