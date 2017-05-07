using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EnableIt.Domain.Infrastructure;

namespace EnableIt.Data.Infrastructure
{
  public interface IRepository<T> where T : BaseEntity
  {
    T GetById(int id);
    IEnumerable<T> Query(Expression<Func<T, bool>> where);
    void Insert(T entity);
    void Update(T entity);
    void Delete(T entity);
    IQueryable<T> Table { get; }
  }
}
