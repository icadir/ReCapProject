using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> carList;

        public InMemoryCarDal()
        {
            carList = new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 2,DailyPrice = 1000,ModelYear = 2000,Description = "BMW-X"},
                new Car{Id = 2,BrandId = 1,ColorId = 2,DailyPrice = 10000,ModelYear = 2000,Description = "Mercedes-X"},
                new Car{Id = 3,BrandId = 2,ColorId = 3,DailyPrice = 100000,ModelYear = 2000,Description = "Tofaş-X"},
                new Car{Id = 4,BrandId = 2,ColorId = 3,DailyPrice = 2000,ModelYear = 2000,Description = "Fiat-X"},
                new Car{Id = 5,BrandId = 3,ColorId = 4,DailyPrice = 20000,ModelYear = 2000,Description = "Opel-X"},
            };
        }

        public Car GetById(Car car)
        {
            return carList.SingleOrDefault(x => x.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return carList;
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            carList.Add(car);
        }

        public void Update(Car car)
        {
            Car carUpdate = carList.SingleOrDefault(x => x.Id == car.Id);
            carUpdate.Id = car.Id;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;

        }

        public void Delete(Car car)
        {
            Car carDelete = carList.SingleOrDefault(x => x.Id == car.Id);
            carList.Remove(carDelete);
        }
    }
}
