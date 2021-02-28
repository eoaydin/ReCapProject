using Business.Concrete;
using DataAccess.Concrete;
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
            CarTest();
            BrandTest();
            ColorTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine("----------GetAll----------");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
            Console.WriteLine("---------AddColor---------");
            Color newColor = new Color
            {
                Name = "Orange"
            };
            colorManager.AddColor(newColor);
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
            Console.WriteLine("--------UpdateColor--------");
            Color colorToUpdate = new Color
            {
                Id = 5,
                Name = "BRG"
            };
            colorManager.UpdateColor(colorToUpdate);
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
            Console.WriteLine("--------GetByColorId--------");
            Console.WriteLine(colorManager.GetByColorId(5).Name);
            Console.WriteLine("--------DeleteColor---------");
            colorManager.DeleteColor(newColor);
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine("----------GetAll----------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
            Console.WriteLine("---------AddBrand---------");
            Brand newBrand = new Brand
            {
                Name = "Peugeot"
            };
            brandManager.AddBrand(newBrand);
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
            Console.WriteLine("--------UpdateBrand--------");
            Brand brandToUpdate = new Brand
            {
                Id = 5,
                Name = "Renault"
            };
            brandManager.UpdateBrand(brandToUpdate);
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
            Console.WriteLine("--------GetByBrandId--------");
            Console.WriteLine(brandManager.GetByBrandId(5).Name);
            Console.WriteLine("--------DeleteBrand---------");
            brandManager.DeleteBrand(newBrand);
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void CarTest()
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
                BrandId = 4,
                ColorId = 4,
                ModelYear = 2020,
                Description = "A4",
                DailyPrice = 630000
            };
            carManager.AddCar(newCar);
            Console.WriteLine("--------GetCarDetails-------");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrize);
            }
            Console.WriteLine("--------UpdateCar-------");
            Car carToUpdateAndDelete = new Car
            {
                Id = 8,
                BrandId = 4,
                ColorId = 4,
                ModelYear = 2020,
                Description = "A5",
                DailyPrice = 750000
            };
            carManager.UpdateCar(carToUpdateAndDelete);
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrize);
            }
            Console.WriteLine("--------DeleteCar-------");
            carManager.DeleteCar(carToUpdateAndDelete);
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrize);
            }
        }
    }
}
