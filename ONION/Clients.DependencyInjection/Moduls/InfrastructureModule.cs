using Clients.Infrastructure.Interfaces;
using Clients.InfratructureServices.Repositories;
using Microsoft.Practices.Unity;

namespace Clients.DependencyInjection.Moduls
{
    public class InfrastructureModule : IModule
    {
        public void Registrate(IUnityContainer container)
        {
            container.RegisterType<IAccountsRepository, AccountsRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IClientsRepository, ClientsRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new ContainerControlledLifetimeManager());
        }
    }
}
