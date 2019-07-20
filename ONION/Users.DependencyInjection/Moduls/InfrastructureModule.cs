using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Users.Infrastructure;
using Users.InfrastructureServices;

namespace Users.DependencyInjection.Moduls
{
    public class InfrastructureModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IUsersRepository, UsersRepository>(new ContainerControlledLifetimeManager());
        }
    }
}
