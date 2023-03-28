using Core.Entities.Concrate;

namespace Entities.Concrate
{
    public class Payment : Entity
    {
        public string CardOwnerNameAndLastName { get; set; }
        public string CreditCardNumber { get; set; }
        public int ExpiringMonth { get; set; }
        public int ExpiringYear { get; set; }
        public int SecurityCode { get; set; }
    }
}