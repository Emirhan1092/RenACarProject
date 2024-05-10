using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Buisness.Abstract
{
    public interface ICarImageService
    {


        IDataResult<List<CarImages>> GetImagesByCarId(int carId);
        IDataResult<List<CarImages>> GetAll();
        IDataResult<CarImages> GetById(int id);
        IResult Add(IFormFile file, CarImages carImage);
        IResult Update(IFormFile file, CarImages carImage);
        IResult Delete(CarImages carImage);

    }

}
