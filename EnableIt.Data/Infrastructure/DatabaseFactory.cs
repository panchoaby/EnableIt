using System.Data.Entity;
using EnableIt.Data.Context;
using EnableIt.Data.Infrastructure;

namespace EnableIt.Data.Data.Infrastructure
{
  public class DatabaseFactory : IDatabaseFactory
  {
    private DbContext _dataContext;

    public DbContext Get()
    {
      return _dataContext ?? (_dataContext = new EnableItContext());
    }

    public void Dispose()
    {
      if (_dataContext != null)
        _dataContext.Dispose();
    }
  }
}
