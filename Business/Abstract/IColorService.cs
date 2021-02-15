using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int brandId);
        void Add(Color brand);
        void Update(Color brand);
        void Delete(Color brand);
    }
}
