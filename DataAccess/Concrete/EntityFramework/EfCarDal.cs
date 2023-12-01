using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal : ICarDal
{

    public bool Add(Car entity)
    {
        using (GameGamerContext context = new GameGamerContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
            return true;
        }
    }

    public bool Delete(Car entity)
    {
        using (GameGamerContext context = new GameGamerContext())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
            return true;
        }
    }

    public Car Get(Expression<Func<Car, bool>> filter)
    {
        using (GameGamerContext context = new GameGamerContext())
        {
            return context.Set<Car>().SingleOrDefault(filter);
        }
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
        using (GameGamerContext contex = new GameGamerContext())
        {
            return filter == null
                ? contex.Set<Car>().ToList()
                : contex.Set<Car>().Where(filter).ToList();
        }
    }

    public bool Update(Car entity)
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
