using Core.Entities.Concrate;

namespace Entities.Concrate
{
    public class Rental : Entity
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}