using Core.DataAccess.EntityFramework;
using DataAccess.Absctract;
using Entities.Concrate;

namespace DataAccess.Concrate.EntityFramework
{
    public class EFBrandDal : EFEntityRepositoryBase<Brand, RentsContext>, IBrandDal
    {
        public EFBrandDal(RentsContext context) : base(context)
        {
        }
    }
}