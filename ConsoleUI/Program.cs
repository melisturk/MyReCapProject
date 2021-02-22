using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //BrandTest();

            //ColorTest();
        }

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorId + " " + color.ColorName);
        //    }


        //}

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal()); ;
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}
            //brandManager.Add(new Brand {BrandName = "BMW"});
            //brandManager.Delete(new Brand { BrandId = 4, BrandName = "Renault" });
            //brandManager.Delete(new Brand { BrandId = 5, BrandName = "Mercedes" });
            //brandManager.Delete(new Brand { BrandId = 6, BrandName = "Opel" });

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if(result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + "/" + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            //foreach (var car in carManager.GetCarDetails().Data)
            //{
            //    Console.WriteLine(car.Id + " - " +  car.BrandName + " - "
            //        + car.ColorName + " - " + car.DailyPrice);
            //}
        }


    }
}
