using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework;

public class EfBrandDal : IBrandDal
{
    public bool Add(Brand entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Brand entity)
    {
        throw new NotImplementedException();
    }

    public Brand Get(Expression<Func<Brand, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Brand> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public List<Brand> GetAllById(int Id)
    {
        throw new NotImplementedException();
    }

    public bool Update(Brand entity)
    {
        throw new NotImplementedException();
    }
}
