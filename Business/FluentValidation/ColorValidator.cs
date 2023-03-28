using Entities.Concrate;
using FluentValidation;

namespace Business.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(color => color.Name).NotEmpty();
            RuleFor(color => color.Name).MinimumLength(2).WithMessage("Renk tanımı 2 karakterden az olamaz.");
        }
    }
}