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
            //BrandTest();
            //ColorTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine("----------GetAll----------");
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }
            Console.WriteLine("---------AddColor---------");
            Color newColor = new Color
            {
                Name = "Orange"
            };
            colorManager.AddColor(newColor);
            foreach (var color in colorManager.GetAll().Data)
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
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }
            Console.WriteLine("--------GetByColorId--------");
            Console.WriteLine(colorManager.GetByColorId(5).Data.Name);
            Console.WriteLine("--------DeleteColor---------");
            colorManager.DeleteColor(newColor);
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine("----------GetAll----------");
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
            Console.WriteLine("---------AddBrand---------");
            Brand newBrand = new Brand
            {
                Name = "Peugeot"
            };
            brandManager.AddBrand(newBrand);
            foreach (var brand in brandManager.GetAll().Data)
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
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
            Console.WriteLine("--------GetByBrandId--------");
            Console.WriteLine(brandManager.GetByBrandId(5).Data.Name);
            Console.WriteLine("--------DeleteBrand---------");
            brandManager.DeleteBrand(newBrand);
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.DeleteCar(new Car { Id = 9 });
            if (result.Success)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
