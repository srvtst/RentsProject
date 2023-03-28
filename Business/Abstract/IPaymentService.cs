using Core.Utilities.Results;
using Entities.Concrate;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        IResult Pay(Payment payment);
    }
}
