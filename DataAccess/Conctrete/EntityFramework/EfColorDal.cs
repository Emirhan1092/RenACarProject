using ConsoleApp1.DataAccess.Abstract;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleApp1.DataAccess.Conctrete.EntityFramework
{

    public class EfColorDal : EfEntityRepositoryBase<Color, CarsContext>,IColorDal

    {
        
    }
}
