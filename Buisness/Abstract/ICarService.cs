using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsBrandId(int brandId);

        List<Car> GetCarsByColorId(int colorId);

    }
  }
