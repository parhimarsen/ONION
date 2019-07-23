namespace Clients.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        IClientsRepository Clients { get; }

        IAccountsRepository Accounts { get; }
    }
}
