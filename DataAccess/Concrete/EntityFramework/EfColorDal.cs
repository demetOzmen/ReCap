using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public bool Add(Color entity)
        {
            using (GameGamerContext context = new GameGamerContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                return true;
            }
        }
        public bool Delete(Color entity)
        {
            using (GameGamerContext context = new GameGamerContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
                return true;
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (GameGamerContext context = new GameGamerContext())
            {
                return context.Set<Color>()
                              .SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (GameGamerContext contex = new GameGamerContext())
            {
                return filter == null
                    ? contex.Set<Color>().ToList()
                    : contex.Set<Color>().Where(filter).ToList();
            }
        }

        public bool Update(Color entity)
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



}
