using Business.Abstract;
using Business.Contants;
using Core.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Absctract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(IFormFile file, CarImage carImages)
        {
            var imageCount = _carImageDal.GetAll(c => c.Id == carImages.Id).Count;
            if (imageCount >= 5)
            {
                return new ErrorResult("One car must have 5 or less images");
            }
            var imageResult = FileHelperManager.Upload(file);

            if (!imageResult.Success)
            {
                return new ErrorResult(imageResult.Message);
            }

            carImages.ImagePath = imageResult.Message;
            carImages.Date = DateTime.Now;
            _carImageDal.Add(carImages);
            return new SuccessResult("car image added");
        }

        public IResult Delete(CarImage carImages)
        {
            var image = _carImageDal.Get(c => c.Id == carImages.Id);
            if (image == null)
            {
                return new ErrorResult("Image not found");
            }
            FileHelperManager.Delete(image.ImagePath);
            _carImageDal.Delete(carImages);
            return new SuccessResult("Image was deleted successfully");
        }

        public IDataResult<CarImage> Get(int Id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == Id)); ;
        }

        public IDataResult<List<CarImage>> GetAll(int Id)
        {
            var result = _carImageDal.GetAll(c => c.Id == Id).Count;
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.Id == Id));
        }

        public IResult Update(IFormFile file, CarImage carImages)
        {
            var image = _carImageDal.Get(c => c.Id == carImages.Id);
            if (image == null)
            {
                return new ErrorResult("Image not found");
            }
            var updateFile = FileHelperManager.Update(file, image.ImagePath);
            if (!updateFile.Success)
            {
                return new ErrorResult(updateFile.Message);
            }
            carImages.ImagePath = updateFile.Message;
            _carImageDal.Update(carImages);
            return new SuccessResult("Car image updated");
        }

    }
}
