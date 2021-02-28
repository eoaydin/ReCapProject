using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetByBrandId(int brandId);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<Car> GetByCarId(int carId);
        IResult AddCar(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult UpdateCar(Car car);
        IResult DeleteCar(Car car);
    }
}
