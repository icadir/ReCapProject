using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> GetById()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Customer user)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customer user)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Customer user)
        {
            throw new NotImplementedException();
        }
    }
}
