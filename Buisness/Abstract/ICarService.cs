
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Buisness.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsBrandId(int brandId);

        IDataResult<List<Car>> GetCarsByColorId(int colorId);

        IDataResult<List<CarDetailDto>>GetCarDetails();
        IDataResult<Car> GetById(int productid);
        IResult Add(Car car);



    }
  }
