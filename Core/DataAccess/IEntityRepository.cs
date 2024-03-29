﻿using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess;

public interface IEntityRepository<T> where T : class, IEntity, new()
{
    bool Add(T entity);
    T AddGet(T entity);
    bool Update(T entity);
    bool Delete(T entity);
    List<T> GetAll(Expression<Func<T, bool>> filter = null);
    T Get(Expression<Func<T, bool>> filter);

}
