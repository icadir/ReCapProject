using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager _carManager = new CarManager(new EfCarDal());
            var carListUsingBrandId = _carManager.GetCarsByBrandId(1);
            var carListUsingColorId = _carManager.GetCarsByColorId(2);

            foreach (var car in carListUsingBrandId)
            {
                Console.WriteLine($"BrandId => {car.Description } - {car.DailyPrice}");
            }

            Console.WriteLine("----------------------------");

            foreach (var car in carListUsingColorId)
            {
                Console.WriteLine($"ColorId => {car.Description } - {car.DailyPrice}");
            }

            Console.WriteLine("--------------------Ekleme İşlemi--------");

            _carManager.Add( new Car
            {
                BrandId = 1,
                ColorId = 2,Description = "TestNice",DailyPrice = 2500,ModelYear = 2018
            });
        }
    }
}
