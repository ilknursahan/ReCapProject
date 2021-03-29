using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   public  class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
               {
                   new Car{Id=1, BrandId=1, ColorId=1, ModelYear="2001", DailyPrice=800, Description="Dizel" },
                   new Car{Id=2, BrandId=1, ColorId=2, ModelYear="2001", DailyPrice=800, Description="Dizel" },
                   new Car{Id=3, BrandId=2, ColorId=1, ModelYear="2005", DailyPrice=1000, Description="Dizel" },
                   new Car{Id=4, BrandId=3, ColorId=1, ModelYear="2007", DailyPrice=1500, Description="Dizel" },
               };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
          
          var  carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
