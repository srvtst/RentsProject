using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class PaymentValidator : AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(p => p.CreditCardNumber).NotEmpty();
            RuleFor(p => p.CardOwnerNameAndLastName).NotEmpty();
            RuleFor(p => p.ExpiringMonth).NotEmpty();
            RuleFor(p => p.ExpiringYear).NotEmpty();
            RuleFor(p => p.SecurityCode).NotEmpty();
        }
    }
}
