﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetByBrandId(int brandId);
        List<Car> GetAll();
        List<Car> GetByDailyPrice(decimal min, decimal max);
        void AddCar(Car car);
    }
}
