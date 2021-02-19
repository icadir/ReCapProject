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
            // CrudTest();
            //TestCarManager();
            // EntitiyCrudTest();
        }

        private static void EntitiyCrudTest()
        {
            UserManager _userManager = new UserManager(new EfUserDal());
            CustomerManager _customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager _rentalManager = new RentalManager(new EfRentalDal());

            var resUser = _userManager.Add(new User
            {
                FirstName = "Fatih",
                LastName = "Çadır",
                Email = "fatihcadir@gmail.com",
                Password = "12345"
            });
            Console.WriteLine($"user Res => {resUser.Message}");
            var resCustomer = _customerManager.Add(new Customer
            {
                CompanyName = "Koç Holding",
                UserId = 1
            });
            Console.WriteLine($"resCustomer Res => {resCustomer.Message}");

            var resRental = _rentalManager.Add(new Rental()
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = DateTime.Now,
            });
            Console.WriteLine($"resRental Res => {resRental.Message}");
        }

        private static void TestCarManager()
        {
            CarManager _carManager = new CarManager(new EfCarDal());

            foreach (var car in _carManager.GetCarDetails().Data)
            {
                Console.WriteLine($"{car.CarId}--{car.CarName}--{car.BrandName}--{car.ColorName}--{car.DailyPrice}");
            }
        }

        private static void CrudTest()
        {
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

            foreach (var car in carListUsingBrandId.Data)
            {
                Console.WriteLine($"BrandId => {car.Description} - {car.DailyPrice}");
            }

            Console.WriteLine("----------------------------");

            foreach (var car in carListUsingColorId.Data)
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
