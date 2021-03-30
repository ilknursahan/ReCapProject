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
            CarManager carManager = new CarManager(new EfCarDal());

          
            var c = new Car { BrandId = 1, ColorId = 1, ModelYear = "2001", DailyPrice = 800, Description = "Dizel" };
            carManager.Add(c);
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.BrandId);
            }

        }
    }
}
