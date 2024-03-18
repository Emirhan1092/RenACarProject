using Buisness.Abstract;
using Buisness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete
{
   
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager()
        {
             
            
        }
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }   

        public IResult Add(Car car)
        {

            if(car.CarName.Length<2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }

            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccesDataResult<List<Car>>(Messages.CarListed);


        }

        public IDataResult<Car> GetById(int carid)
        {
            return new SuccesDataResult<Car>(_carDal.Get(p => p.CarId == carid), Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccesDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());

        }

        public IDataResult<List<Car>> GetCarsBrandId(int brandId)
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId), Messages.CarListed);
        }




        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(p => p.CarId == colorId), Messages.CarListed);

        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
