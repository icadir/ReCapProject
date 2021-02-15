using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.GetById(x=>x.Id == colorId);
        }

        public void Add(Color brand)
        {
            _colorDal.Add(brand);
        }

        public void Update(Color brand)
        {
          _colorDal.Update(brand);
        }

        public void Delete(Color brand)
        {
            _colorDal.Delete(brand);
        }
    }
}
