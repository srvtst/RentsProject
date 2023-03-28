using Core.Entities.Concrate;

namespace Entities.Concrate
{
    public class CarImage : Entity
    {
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}