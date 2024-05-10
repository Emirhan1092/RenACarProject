using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsContext>, ICarDal
    {
        
            public List<CarDetailDto> GetCarDetails()
            {
                using (CarsContext context = new CarsContext())
                {
                    var result = from car in context.Cars
                                 join brand in context.Brands on car.BrandId equals brand.Id
                                 join color in context.Colors on car.ColorId equals color.Id
                                 select new CarDetailDto
                                 { 
                                     CarName = car.CarName,
                                     BrandName = brand.BrandName,
                                     ColorName = color.ColorName,
                                     DailyPrice = (decimal)car.DailyPrice,

                                 };

                    return result.ToList();
                }
            }

    }
}
       