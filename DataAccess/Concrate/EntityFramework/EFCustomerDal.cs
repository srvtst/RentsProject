using Core.DataAccess.EntityFramework;
using DataAccess.Absctract;
using Entities.Concrate;

namespace DataAccess.Concrate.EntityFramework
{
    public class EFCustomerDal : EFEntityRepositoryBase<Customer, RentsContext>, ICustomerDal
    {
        public EFCustomerDal(RentsContext context) : base(context)
        {
        }
    }
}