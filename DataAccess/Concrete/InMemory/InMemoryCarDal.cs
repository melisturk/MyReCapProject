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
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=100, Description ="Renault Symbol", ModelYear=2015},
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=200, Description ="Ford Fiesta", ModelYear=2017},
                new Car{Id=3, BrandId=3, ColorId=3, DailyPrice=300, Description ="Audi A3", ModelYear=2019},
                new Car{Id=4, BrandId=4, ColorId=1, DailyPrice=450, Description ="Mercedes Benz GLA ", ModelYear=2020},
                new Car{Id=5, BrandId=5, ColorId=2, DailyPrice=120, Description ="Opel Corsa", ModelYear=2014},

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
        List<Car> ICarDal.GetAll()
        {
            return _cars;
        }

        List<Car> ICarDal.GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }

       
    }
}
