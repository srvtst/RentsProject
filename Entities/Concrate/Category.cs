using Core.Entities.Concrate;

namespace Entities.Concrate
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public List<Car>? Cars { get; set; }
        public Category(string name)
        {
            Name = name;
        }
        public Category()
        {
            List<Car> cars = new List<Car>();
        }
    }
}