using Core.Utilities.Results;
using Entities.Concrate;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
       // IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<Car>> GetByColor(int colorId);
        IDataResult<List<Car>> GetByBrand(int brandId);
        IDataResult<List<Car>> GetByCategory(int categoryId);
        IDataResult<Car> GetByCar(int carId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        //transaction yönetimi -- uygulamalarda tutarlılığı korumak için yaptığımız bir yöntem.
        IResult TransactionalOperation(Car car);
    }
}