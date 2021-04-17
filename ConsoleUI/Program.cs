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
            CarList();

            RentalTest();

            Console.ReadKey();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());




            var rental = new Rental { CarId = 4, CustomerId = 2, RentDate = DateTime.Now };
            var state = rentalManager.Add(rental);

            if (state.Success == true)
            {

                Console.WriteLine("eklendi");

            }

            else
            {
                Console.WriteLine(state.Message);
            }
        }

        private static void CarList()
        {
            CarManager carManager = new CarManager(new EfCarDal());


            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.BrandName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
