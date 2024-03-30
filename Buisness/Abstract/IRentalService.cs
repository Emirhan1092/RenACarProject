using Core.Utilities.Results;
using Entities.Concrete;

namespace Buisness.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> Get(int id);
        
    }
}
