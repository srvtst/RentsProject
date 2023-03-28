using Core.Entities.Concrate;

namespace Entities.Concrate
{
    public class Brand : Entity
    {
        public string Name { get; set; }
        public Car? Car { get; set; }
        public Brand(string name)
        {
            Name = name;
        }
        public Brand()
        {

        }
    }
}