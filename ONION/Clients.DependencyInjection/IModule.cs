using Microsoft.Practices.Unity;

namespace Clients.DependencyInjection
{
    public interface IModule
    {
        void Registrate(IUnityContainer container);
    }
}
