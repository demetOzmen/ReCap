using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework;

public class EfBrandDal : EFEntityRepositoryBase<Brand, GameGamerContext>,IBrandDal
{
    public bool Add(Brand entity)
    {
        using (GameGamerContext context = new GameGamerContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
            return true;
        }
    }

    public bool Delete(Brand entity)
    {
        using (GameGamerContext context = new GameGamerContext())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
            return true;
        }
    }

    public Brand Get(Expression<Func<Brand, bool>> filter)
    {
        using (GameGamerContext context = new GameGamerContext())
        {
            return context.Set<Brand>().SingleOrDefault(filter);
        }
    }


    public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
    {
        using (GameGamerContext contex = new GameGamerContext())
        {
            return filter == null
                ? contex.Set<Brand>().ToList()
                : contex.Set<Brand>().Where(filter).ToList();
        }
    }

    public List<Brand> GetAllById(int Id)
    {
        throw new NotImplementedException();
    }

    public bool Update(Brand entity)
    {
        using (GameGamerContext context = new GameGamerContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
            return true;
        }
    }
}
