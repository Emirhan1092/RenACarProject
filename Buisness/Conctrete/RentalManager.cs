using Buisness.Abstract;
using Buisness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Conctrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
           if( CarDelivery==null )
            {
                _rentalDal.Add(rental);

                return new SuccessResult(Messages.RentAdded);
            }
            else
            {
                return new ErrorResult(Messages.RentAdded);

            }

        }

        public IResult CarDelivery(int id)
        {
            var rental = _rentalDal.Get(r => r.CarId == id);

            if (rental != null)
            {
                
                _rentalDal.Delete(rental);
                return new SuccessResult(Messages.CarDelivered);
            }
            else
            {
                
                return new ErrorResult(Messages.CarNotDelivered);
            }
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<Rental> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccesDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
