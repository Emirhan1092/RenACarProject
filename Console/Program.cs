using Buisness.Concrete;
using Buisness.Conctrete;
using DataAccess.Concrete.EntityFramework;
namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerGetAllTest();
            CarGetAllTest();
        }

        private static void CustomerGetAllTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();

            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine("Customer Name: " + customer.CompanyName);

                }


            }
        }
        private static void CarGetAllTest()
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            var result = carmanager.GetAll();  
            if(result.Success) 
            {
              foreach(var car in result.Data)
                {
                    Console.WriteLine("Cars Name :" + car.CarName);
                }
            
            
            
            }
        }
    }
}

