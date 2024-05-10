
using Buisness.Abstract;
using Buisness.Constants;
using Buisness.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Buisness.Conctrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
         public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);

            _customerDal.Add(customer);

            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);

            return new SuccessResult(Messages.CustomerDeleted);
        }
        public IDataResult<List<Customer>> GetAll()
        {
            var customers = _customerDal.GetAll();
            return new SuccesDataResult<List<Customer>>(customers, Messages.CustomerListed);
        }


        public IDataResult<Customer> GetById(int customerid)
        {
            return new SuccesDataResult<Customer>(_customerDal.Get(p => p.Id == customerid), Messages.CustomerListed);

        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
