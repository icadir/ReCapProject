using DataAccess.Abstract;

namespace Business.Concrete
{
    public class BrandManager
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
    }
}
