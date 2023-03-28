using Core.DataAccess;
using Entities.Concrate;

namespace DataAccess.Absctract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        //List<CarDetailDto> GetCarDetails();
    }
}