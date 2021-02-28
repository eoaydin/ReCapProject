using Entities.Concrete;
using Entities.DTOs;
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
        Car GetByCarId(int carId);
        void AddCar(Car car);
        List<CarDetailDto> GetCarDetails();
        void UpdateCar(Car car);
        void DeleteCar(Car car);
    }
}
