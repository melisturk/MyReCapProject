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

            //UserAddTest();

            //UserTest();

            //CustomerAddTest();

            //CustomerTest();
            //RentalAddTest();
        }
        private static void UserAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { FirstName = "Melis", LastName = "Türk", Email = "melis-abc@gmail.com", Password = "1234" });
            Console.WriteLine(result.Message);
            var result2 = userManager.Add(new User { FirstName = "Ayberk", LastName = "Akın", Email = "ayberk-bcd@gmail.com", Password = "5678" });
            Console.WriteLine(result2.Message);
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine("UserId: {0} FirstName: {1} LastName: {2} Email: {3} Password: {4}"
                    , user.Id, user.FirstName, user.LastName, user.Email, user.Password);
            }
        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer { CustomerId = 1, UserId = 1, CompanyName = "Melis Company" });
            Console.WriteLine(result.Message);
            var result2 = customerManager.Add(new Customer { CustomerId = 2, UserId = 2, CompanyName = "Ayberk Company" });
            Console.WriteLine(result2.Message);
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine("CustomerId: {0} CompanyName: {1} UserId: {2}"
                    , customer.CustomerId, customer.CompanyName, customer.UserId);
            }
        }
        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 02, 15), ReturnDate = new DateTime(2021, 02, 25) });
            Console.WriteLine(result.Message);

        }

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorId + " " + color.ColorName);
        //    }


        //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal()); ;
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }
        //    brandManager.Add(new Brand { BrandName = "BMW" });
        //    brandManager.Delete(new Brand { BrandId = 4, BrandName = "Renault" });
        //    brandManager.Delete(new Brand { BrandId = 5, BrandName = "Mercedes" });
        //    brandManager.Delete(new Brand { BrandId = 6, BrandName = "Opel" });

        //}

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
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
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.Id + " - " + car.BrandName + " - "
                    + car.ColorName + " - " + car.DailyPrice);
            }
        }


    }
}

