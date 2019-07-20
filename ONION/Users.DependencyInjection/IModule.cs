using Microsoft.Practices.Unity;

namespace Users.DependencyInjection
{
    public interface IModule
    {
        void Register(IUnityContainer container);
    }
}
