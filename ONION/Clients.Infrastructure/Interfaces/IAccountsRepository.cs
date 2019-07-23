using Clients.Infrastructure.Models;
using System.Collections.Generic;

namespace Clients.Infrastructure.Interfaces
{
    public interface IAccountsRepository
    {
        IEnumerable<InfrastructureAccount> GetAccounts(int limit, int offset);

        InfrastructureAccount GetAccount(int clientId);

        IEnumerable<InfrastructureAccount> GetAccountsOfClient(int clientId);

        InfrastructureAccount GetAccountOfClient(int clientId, int accountId);

        InfrastructureAccount CreateAccount(InfrastructureAccount account);

        void DeleteAccount(int accountId);

        bool UpdateAccount(int accountId, InfrastructureAccount account);
    }
}
