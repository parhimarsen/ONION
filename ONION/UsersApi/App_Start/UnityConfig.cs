using Microsoft.Practices.Unity;
using System.Web.Http;
using Clients.DependencyInjection;
using Clients.DependencyInjection.Moduls;
using Unity.WebApi;

namespace UsersApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            Registrate<DomainModule>(container);
            Registrate<InfrastructureModule>(container);

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static void Registrate<T>(IUnityContainer container) where T : IModule, new ()
        {
            new T().Registrate(container);
        }

    }
}