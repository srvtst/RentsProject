using Core.DataAccess.EntityFramework;
using DataAccess.Absctract;
using Entities.Concrate;

namespace DataAccess.Concrate.EntityFramework
{
    public class EFRentalDal : EFEntityRepositoryBase<Rental, RentsContext>, IRentalDal
    {
        public EFRentalDal(RentsContext context) : base(context)
        {
        }
    }
}