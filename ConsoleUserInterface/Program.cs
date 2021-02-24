using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("----------GetAll----------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("--------GetByBrandId-------");
            foreach (var car in carManager.GetByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("-------GetByDailyPrize-----");
            foreach (var car in carManager.GetByDailyPrice(300000, 600000))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("-----------AddCar----------");
            Car newCar = new Car
            {
                BrandId = 1,
                ColorId = 2,
                ModelYear = 2021,
                Description = "S",
                DailyPrice = 350000
            };
            carManager.AddCar(newCar);
        }
    }
}
