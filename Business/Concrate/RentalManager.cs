using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Absctract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new Result(true);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new Result(true);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new Result(true);
        }
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetByRentalId(int rentalid)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalid));
        }
    }
}