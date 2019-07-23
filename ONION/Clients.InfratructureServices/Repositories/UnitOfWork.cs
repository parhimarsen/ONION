using Clients.Infrastructure.Interfaces;
using Clients.InfratructureServices.Repositories;

namespace Clients.InfratructureServices.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private AccountsRepository accountsRepository;
        private ClientsRepository clientsRepository;


        public IClientsRepository Clients
        {
            get
            {
                if (clientsRepository == null)
                    clientsRepository = new ClientsRepository();
                return clientsRepository;
            }
        }

        public IAccountsRepository Accounts
        {
            get
            {
                if (accountsRepository == null)
                    accountsRepository = new AccountsRepository();
                return accountsRepository;
            }
        }
    }
}
