using Core.DataAccess.EntityFramework;
using DataAccess.Absctract;
using Entities.Concrate;

namespace DataAccess.Concrate.EntityFramework
{
    public class EFCarImageDal : EFEntityRepositoryBase<CarImage, RentsContext>, ICarImageDal
    {
        public EFCarImageDal(RentsContext context) : base(context)
        {
        }
    }
}