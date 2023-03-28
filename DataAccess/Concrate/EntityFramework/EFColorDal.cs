using Core.DataAccess.EntityFramework;
using DataAccess.Absctract;
using Entities.Concrate;

namespace DataAccess.Concrate.EntityFramework
{
    public class EFColorDal : EFEntityRepositoryBase<Color, RentsContext>, IColorDal
    {
        public EFColorDal(RentsContext context) : base(context)
        {
        }
    }
}