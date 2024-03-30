
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Entities.Concrete
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarsContext>, IBrandDal
    {
    } 
}
