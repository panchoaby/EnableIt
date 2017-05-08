using System.Reflection;
using System.Web.Mvc;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using EnableIt.Application.Infrastructure;
using EnableIt.Web.App_Start;

[assembly:WebActivatorEx.PostApplicationStartMethod(typeof(SimpleInjectorInitializer),"Initialize")]

namespace EnableIt.Web.App_Start
{
    public class SimpleInjectorInitializer
    {
        public static Container InjectorContainer { get; set; }

        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            // Did you know the container can diagnose your configuration? Go to: http://bit.ly/YE8OJj.
            var container = new Container();
            InjectorContainer = container;

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.RegisterMvcIntegratedFilterProvider();
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            var webReqLifeCycle = new WebRequestLifestyle();
            DependencyContainerMapper.InitializeContainer(container, webReqLifeCycle);
        }
    }
}