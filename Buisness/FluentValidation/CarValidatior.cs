using Entities.Concrete;
using FluentValidation;


namespace Buisness.FluentValidation
{
    public class CarValidatior:AbstractValidator<Car>
    {
        public CarValidatior()
        {
            RuleFor(p => p.CarId).NotEmpty();
            RuleFor(p => p.CarName).MinimumLength(2);
            RuleFor(p => p.BrandId).NotEmpty();   
            RuleFor(p=>p.ColorId).NotEmpty();
            RuleFor(p=>p.ModelYear).GreaterThanOrEqualTo(1900);
            RuleFor(p=>p.DailyPrice).NotNull(); 
            RuleFor(p=>p.Descriptions).NotEmpty();   
        }
    }
 
}
