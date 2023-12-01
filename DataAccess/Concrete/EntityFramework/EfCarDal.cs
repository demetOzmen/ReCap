using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal : ICarDal
{
    public bool Add(Car entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Car entity)
    {
        throw new NotImplementedException();
    }

    public Car Get(Expression<Func<Car, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public bool Update(Car entity)
    {
        throw new NotImplementedException();
    }
}
