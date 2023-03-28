using Entities.Concrate;
using FluentValidation;

namespace Business.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Name).NotEmpty();
            RuleFor(b => b.Name).MinimumLength(2).WithMessage("Marka ismi 2 karakterden az olamaz.");
        }
    }
}