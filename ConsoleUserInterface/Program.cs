using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
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
            Console.WriteLine("-----------Delete----------");
            carManager.Delete(new Entities.Concrete.Car { Id = 3, BrandId = 2, ColorId = 5, DailyPrice = 390000, ModelYear = 2021, Description = "Audi A3" });
            Console.WriteLine("The Car Deleted. New Car List is Below");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("------------Add------------");
            carManager.Add(new Entities.Concrete.Car { Id = 6, BrandId = 4, ColorId = 8, DailyPrice = 230000, ModelYear = 2021, Description = "Seat Leon" });
            Console.WriteLine("The Car is Added. New Car List is Below");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("-----------Update----------");
            carManager.Update(new Entities.Concrete.Car { Id = 6, BrandId = 1, ColorId = 8, DailyPrice = 750000, ModelYear = 2021, Description = "BMW 520" });
            Console.WriteLine("The Car is Updated. New Car List is Below");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
