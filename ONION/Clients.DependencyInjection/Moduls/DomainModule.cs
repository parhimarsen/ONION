using Clients.Domain.Interfaces;
using Clients.DomainServices.Services;
using Microsoft.Practices.Unity;

namespace Clients.DependencyInjection.Moduls
{
    public class DomainModule : IModule
    {
        public void Registrate(IUnityContainer container)
        {
            container.RegisterType<IAccountsService, AccountsService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IClientsService, ClientsService>(new ContainerControlledLifetimeManager());
        }
    }
}
