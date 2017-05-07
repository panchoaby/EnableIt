using System.Data.Entity;

namespace EnableIt.Data.Infrastructure
{
  public interface IDatabaseFactory
  {
    DbContext Get();
  }
}