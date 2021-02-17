using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Rental> GetById()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Rental user)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rental user)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Rental user)
        {
            throw new NotImplementedException();
        }
    }
}
