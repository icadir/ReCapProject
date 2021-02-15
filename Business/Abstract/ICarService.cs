using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface ICarService
   {
       List<Car> GetAllCar();
       List<Car> GetCarsByBrandId(int brandId);
       List<Car> GetCarsByColorId(int colorId);
       void Add(Car car);
       void Update(Car car);
    }
}
