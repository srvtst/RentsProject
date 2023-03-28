using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Contants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Absctract;
using Entities.Concrate;
using System.Collections.Generic;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [CacheAspect]
        [SecuredOperation("product.admin")]
        [PerformanceAspect(10)]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Message.CarListed);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetByBrand(int brandid)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(b => b.BrandId == brandid));
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetByColor(int colorid)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorid));
        }

        //[SecuredOperation("product.admin")]
        [CacheRemoveAspect("ICarService.Get")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfCarCountCategory(car.CategoryId));
            if (result != null)
            {
                return new ErrorResult();
            }
            _carDal.Add(car);
            return new Result(true, Message.CarAdded);
        }

        //car serviceteki bütün getleri sil.
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true, Message.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(true, Message.CarDeleted);
        }

        //public IDataResult<List<CarDetailDto>> GetCarDetails()
        //{
        //    return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        //}

        [CacheAspect]
        [PerformanceAspect(10)]
        public IDataResult<Car> GetByCar(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == carId));
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetByCategory(int categoryid)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.CategoryId == categoryid));
        }

        //kategorideki ürün sayısının kurallarına uygunluğunu doğrula
        private IResult CheckIfCarCountCategory(int categoryid)
        {
            var result = _carDal.GetAll(c => c.CategoryId == categoryid).Count;
            if (result > 100)
            {
                return new ErrorResult("Kategoride ürün limiti aşıldı");
            }
            return new SuccessResult();
        }

        [TransactionScopeAspect]
        public IResult TransactionalOperation(Car car)
        {
            _carDal.Update(car);
            _carDal.Add(car);
            return new SuccessResult(Message.CarUpdated);
        }

    }
}