using EnableIt.Domain.Infrastructure;

namespace EnableIt.Data.Infrastructure
{
  public interface IUnitOfWork
  {
    void Dispose();
    void Save();
    void Dispose(bool disposing);
    Repository<T> Repository<T>() where T : BaseEntity;
  }
}