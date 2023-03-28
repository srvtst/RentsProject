using Core.Entities.Concrate;

namespace Entities.Concrate
{
    public class Car : Entity
    {
        public int CategoryId { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Color Color { get; set; }
        public Brand Brand { get; set; }
        public Car(string name, int modelYear, decimal dailyPrice, string description)
        {
            Name = name;
            ModelYear = modelYear;
            DailyPrice = dailyPrice;
            Description = description;
        }
        public Car()
        {

        }
    }
}