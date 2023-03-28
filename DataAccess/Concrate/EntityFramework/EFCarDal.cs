using Core.DataAccess.EntityFramework;
using DataAccess.Absctract;
using Entities.Concrate;

namespace DataAccess.Concrate.EntityFramework
{
    public class EFCarDal : EFEntityRepositoryBase<Car, RentsContext>, ICarDal
    {
        public EFCarDal(RentsContext context) : base(context)
        {
        }
    }
}