using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager _carManager = new CarManager(new EntityFrameworkCarDal());
            var list = _carManager.GetAllCar();

            foreach (var car in list)
            {
                Console.WriteLine("Car Aciklama = " + car.Description);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
