using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory;

public class InMemoryBrandDal : IBrandDal
{
    public bool Add(Brand brand)
    {
        throw new NotImplementedException();
    }

    public Brand AddGet(Brand entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Brand brand)
    {
        throw new NotImplementedException();
    }

    public Brand Get(Expression<Func<Brand, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAllById(int Id)
    {
        throw new NotImplementedException();
    }

    public bool Update(Brand brand)
    {
        throw new NotImplementedException();
    }
}
