﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService 
    {
        List<Car> GetAll();

        List<Car> GetAllByBrandId(int brandId);

        List<Car> GetByDailyPrice(decimal min, decimal max);

        Car Add(Car car);


    }
}
