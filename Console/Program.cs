using Buisness.Concrete;
using Buisness.Conctrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerGetAllTest();
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
    }
}

