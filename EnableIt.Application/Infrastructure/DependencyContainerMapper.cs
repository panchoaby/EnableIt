using EnableIt.Data.Data.Infrastructure;
using EnableIt.Data.Infrastructure;
using SimpleInjector;

namespace EnableIt.Application.Infrastructure
{
    public class DependencyContainerMapper
    {
        public static void InitializeContainer(Container container, Lifestyle lifeStyle)
        {
            //database      
            container.Register<IDatabaseFactory, DatabaseFactory>(lifeStyle);
            container.Register<IUnitOfWork, UnitOfWork>(lifeStyle);

            //register generic repository
            container.Register(typeof(IRepository<>), typeof(Repository<>), lifeStyle);
            container.Register(typeof(IService<>), typeof(Service<>), lifeStyle);

        }
    }
}
