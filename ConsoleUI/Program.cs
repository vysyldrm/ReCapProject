using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Abstract;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car {Id = 1, ColorId = 1, BrandId = 1, DailyPrice = 100, Description = "Mercedes", ModelYear = 2022 };
            //Car car2 = new Car {Id = 2, ColorId = 1, BrandId = 1, DailyPrice = 0, Description = "Audi", ModelYear = 2022 };
            //Car car3 = new Car {Id = 3, ColorId = 1, BrandId = 1, DailyPrice = 150, Description = "BB", ModelYear = 2022 };
            //Car car4 = new Car { Id = 4, ColorId = 1, BrandId = 2, DailyPrice = 100, Description = "Ferrari", ModelYear = 2022 };
            //Car car5 = new Car { Id = 5, ColorId = 2, BrandId = 2, DailyPrice = 100, Description = "McLaren", ModelYear = 2022 };

            CarManager carManager = new CarManager(new EfCarDal());


            //carManager.Add(car1);
            //carManager.Add(car2);
            //carManager.Add(car3);
            //carManager.Add(car4);
            //carManager.Add(car5);



            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            //foreach (var car in carManager.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine(car.Description);
            //}

            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
