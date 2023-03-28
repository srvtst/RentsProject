using Core.DataAccess.EntityFramework;
using DataAccess.Absctract;
using Entities.Concrate;

namespace DataAccess.Concrate.EntityFramework
{
    public class EFCategoryDal : EFEntityRepositoryBase<Category, RentsContext>, ICategoryDal
    {
        public EFCategoryDal(RentsContext context) : base(context)
        {
        }
    }
}