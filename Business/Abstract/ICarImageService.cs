using Core.Utilities.Results;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImage carImages);
        IResult Update(IFormFile file, CarImage carImages);
        IResult Delete(CarImage carImages);
        IDataResult<List<CarImage>> GetAll(int Id);
        IDataResult<CarImage> Get(int Id);
    }
}