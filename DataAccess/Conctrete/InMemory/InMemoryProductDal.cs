

using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Conctrete.InMemory
{

    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryProductDal()

        {
            _cars = new List<Car>(){

                new Car { CarId = 1, ColorId = 1, BrandId = 1, DailyPrice = 240000, ModelYear = 2009, Descriptions = "Megan" },
                new Car { CarId = 2, ColorId = 2, BrandId = 2, DailyPrice = 500000, ModelYear = 2023, Descriptions = "Poursch" },
                new Car { CarId = 3, ColorId = 2, BrandId = 2, DailyPrice = 4001000, ModelYear = 2024, Descriptions = "Toyota" },
                new Car { CarId = 4, ColorId = 3, BrandId = 2, DailyPrice = 700000, ModelYear = 2019, Descriptions = "Doblo" },
                new Car {CarId = 5, ColorId = 3, BrandId = 2, DailyPrice = 800000, ModelYear = 2018, Descriptions = "Ferrari" },
                new Car {CarId = 6, ColorId = 3, BrandId = 4, DailyPrice = 900000, ModelYear = 2017, Descriptions = "Renault" },
                new Car {CarId = 7, ColorId = 4, BrandId = 5, DailyPrice = 500000, ModelYear = 2016, Descriptions = "Megan" },
                new Car {CarId = 8, ColorId = 4, BrandId = 3, DailyPrice = 234000, ModelYear = 2014, Descriptions = "Poursch" },
                new Car { CarId = 9, ColorId = 5, BrandId = 5, DailyPrice = 2221000, ModelYear = 2001, Descriptions = "Megan" }
            };


        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Remove(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            if (carToDelete != null)
            {
                _cars.Remove(carToDelete);
            }
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
