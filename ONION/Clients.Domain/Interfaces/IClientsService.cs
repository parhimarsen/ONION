using Clients.Domain.Models;
using System.Collections.Generic;

namespace Clients.Domain.Interfaces
{
    public interface IClientsService
    {
        IEnumerable<DomainClient> GetClients(SearchingGetAllFilter filter);

        DomainClient GetClient(int clientId);

        IEnumerable<DomainAccount> GetAccountsOfClient(int clientId);

        DomainAccount GetAccountOfClient(int clientId, int accountId);

        DomainClient CreateClient(DomainClient client);

        void DeleteClient(int clientId);

        bool UpdateClient(int clientId, DomainClient client);
    }
}
