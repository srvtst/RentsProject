using Core.DataAccess.EntityFramework;
using DataAccess.Absctract;
using Entities.Concrate;

namespace DataAccess.Concrate.EntityFramework
{
    public class EFPaymentDal : EFEntityRepositoryBase<Payment, RentsContext>, IPaymentDal
    {
        public EFPaymentDal(RentsContext context) : base(context)
        {
        }
    }
}