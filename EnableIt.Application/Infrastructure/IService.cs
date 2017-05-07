using EnableIt.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EnableIt.Application.Infrastructure
{
    public interface IService<T> where T : BaseEntity
    {
        T GetByID(int id);
        T GetFirst();
        T GetFirst(Expression<Func<T, bool>> whereClause);
        List<T> GetMany(Expression<Func<T, bool>> whereClause);
        List<T> GetAll();

        T Add(T entity);
        void AddList(List<T> entities);
        List<T> AddEntities(List<T> entities);
        T Update(T entity);
        void Delete(T entity);

    }
}
