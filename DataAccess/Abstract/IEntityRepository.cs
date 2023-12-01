﻿using Entities.Abstract;
using System.Linq.Expressions;

namespace DataAccess.Abstract;

public interface IEntityRepository<T> where T : class, IEntity, new()
{
    bool Add(T entity);
    bool Update(T entity);
    bool Delete(T entity);
    List<T> GetAll(Expression<Func<T,bool>> filter = null);
    T Get(Expression<Func<T, bool>> filter);
   
}