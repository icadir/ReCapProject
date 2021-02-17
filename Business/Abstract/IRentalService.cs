using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById();
        IResult Add(Rental user);
        IResult Update(Rental user);
        IResult Delete(Rental user);
    }
}
