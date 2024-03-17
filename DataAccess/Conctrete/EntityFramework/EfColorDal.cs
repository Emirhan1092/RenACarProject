using ConsoleApp1.DataAccess.Abstract;
using ConsoleApp1.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.Entityframework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataAccess.Conctrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarsContext>,IColorDal

    {
        
    }
}
