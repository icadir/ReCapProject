using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAllCar()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(x => x.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(x => x.ColorId == colorId);
        }

        public void Add(Car car)
        {
            if (car.Description.Length <= 2)
                throw new Exception("Araba İsmi Minimum 3 Karakter Olmalıdır.");
            else if (car.DailyPrice <= 0)
                throw new Exception($"Araba Fiyatı Minimum 1 TL Olmalıdır.");
            else
                _carDal.Add(car);
        }
    }
}
