
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Buisness.Abstract
{
    public interface IUserService
    {
        List<OperationClaim>GetClaims(User user);

        void Add(User user); 

        User GetByMail(string Mail);


    }
}
