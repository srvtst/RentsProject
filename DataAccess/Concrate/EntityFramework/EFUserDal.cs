using Core.DataAccess.EntityFramework;
using Core.Entities.Concrate;
using DataAccess.Absctract;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DataAccess.Concrate.EntityFramework
{
    public class EFUserDal : EFEntityRepositoryBase<User, RentsContext>, IUserDal
    {
        public EFUserDal(RentsContext context) : base(context)
        {
        }

        public List<OperationClaim> GetClaims(User user)
        {
            var result = from oc in Context.OperationClaims
                         join uoc in Context.UserOperationClaims on
                         oc.ClaimId equals uoc.ClaimId
                         where user.Id == uoc.UserId
                         select new OperationClaim
                         {
                             ClaimId = uoc.ClaimId,
                             ClaimName = oc.ClaimName
                         };
            return result.ToList();
        }
    }
}