using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Conctrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,CarsContext>,IUserDal
    {
    }
}
