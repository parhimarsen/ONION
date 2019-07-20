using Domain.Interfaces;
using Microsoft.Practices.Unity;
using Users.DomainServices.Services;
using Users.Infrastructure;
using Users.InfrastructureServices;

namespace Users.DependencyInjection.Moduls
{
    public class DomainModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IUsersService, UsersService>(new ContainerControlledLifetimeManager());
        }
    }
}
