using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conctrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarsContext>, IRentalDal

    {
    }
}
