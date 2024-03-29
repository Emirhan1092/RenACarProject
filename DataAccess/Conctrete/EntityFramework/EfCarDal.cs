﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsContext>, ICarDal
    {
        
            public List<CarDetailDto> GetCarDetails()
            {
                using (CarsContext context = new CarsContext())
                {
                    var result = from car in context.Car
                                 join brand in context.Brand on car.BrandId equals brand.BrandId
                                 join color in context.Color on car.ColorId equals color.ColorId
                                 select new CarDetailDto
                                 { 
                                     CarName = car.Description,
                                     BrandName = brand.BrandName,
                                     ColorName = color.ColorName,
                                     DailyPrice = (decimal)car.DailyPrice,

                                 };

                    return result.ToList();
                }
            }

    }
}
       