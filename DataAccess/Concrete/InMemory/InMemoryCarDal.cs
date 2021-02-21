using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 550000, ModelYear = 2021, Description = "BMW 320"},
                new Car{Id = 2, BrandId = 1, ColorId = 3, DailyPrice = 400000, ModelYear = 2021, Description = "BMW 118"},
                new Car{Id = 3, BrandId = 2, ColorId = 5, DailyPrice = 390000, ModelYear = 2021, Description = "Audi A3"},
                new Car{Id = 4, BrandId = 3, ColorId = 1, DailyPrice = 150000, ModelYear = 2020, Description = "Fiat Egea"},
                new Car{Id = 5, BrandId = 4, ColorId = 2, DailyPrice = 3000000, ModelYear = 2021, Description = "Mercedes S"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
