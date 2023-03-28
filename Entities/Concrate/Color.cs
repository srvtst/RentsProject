using Core.Entities.Concrate;

namespace Entities.Concrate
{
    public class Color : Entity
    {
        public string Name { get; set; }
        public Car? Car { get; set; }
        public Color(string name)
        {
            Name = name;
        }
        public Color()
        {

        }
    }
}