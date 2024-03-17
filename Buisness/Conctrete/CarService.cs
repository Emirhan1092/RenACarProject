using Buisness.Abstract;
using ConsoleApp1.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using DataAccess.Concrete.Entityframework;
using System;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Buisness.Conctrete
{
   
    public class CarService : ICarService
    {
        ICarDal _carDal;

        public CarService(ICarDal carDal)
        {
             
             _carDal = carDal;
        }


        public List<Car> GetAll()
        {
           return  _carDal.GetAll();

        }

        public List<Car> GetCarsBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId ==brandId);
        }


     

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        }
    }
}
