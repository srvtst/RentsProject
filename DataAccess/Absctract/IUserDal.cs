using Core.DataAccess;
using Core.Entities.Concrate;
using System.Collections.Generic;

namespace DataAccess.Absctract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
