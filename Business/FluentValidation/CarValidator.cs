using Entities.Concrate;
using FluentValidation;

namespace Business.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Araba ismi boş olamaz.");
            RuleFor(c => c.Name).MinimumLength(3);
            RuleFor(c => c.Description).MinimumLength(10);
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("Fiyat boş olmamalıdır.");
        }
    }
}