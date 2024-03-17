using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Buisness.Conctrete;
using DataAccess.Conctrete.InMemory;

namespace ConsoleUI
{
    class Program

    {
        static void Main(string[] args)
        {


            CarService carService = new CarService(new InMemoryProductDal());
            foreach (var car in carService.GetAll())
            {
                Console.WriteLine(car.Description);

            }


        }
    }
}