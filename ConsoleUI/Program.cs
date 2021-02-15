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
            //Test();

            BrandManager _brandManager = new BrandManager(new EfBrandDal());
            CarManager _carManager = new CarManager(new EfCarDal());
            ColorManager _colorManager = new ColorManager(new EfColorDal());
            _carManager.Update(new Car
            {
                Id = 1,
                BrandId = 1,
                ColorId = 2,
                Description = "updateTest",
                DailyPrice = 3500,
                ModelYear = 2200
            });
            _brandManager.Add(new Brand
            {
                Name = "Ferrari"
            });

            _colorManager.Add(new Color
            {
                Name = "PembeX"
            });


        }

        private static void Test()
        {
            CarManager _carManager = new CarManager(new EfCarDal());
            var carListUsingBrandId = _carManager.GetCarsByBrandId(1);
            var carListUsingColorId = _carManager.GetCarsByColorId(2);

            foreach (var car in carListUsingBrandId)
            {
                Console.WriteLine($"BrandId => {car.Description} - {car.DailyPrice}");
            }

            Console.WriteLine("----------------------------");

            foreach (var car in carListUsingColorId)
            {
                Console.WriteLine($"ColorId => {car.Description} - {car.DailyPrice}");
            }

            Console.WriteLine("--------------------Ekleme İşlemi--------");

            _carManager.Add(new Car
            {
                BrandId = 1,
                ColorId = 2,
                Description = "TestNice",
                DailyPrice = 2500,
                ModelYear = 2018
            });
        }
    }
}
