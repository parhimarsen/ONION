using Clients.Infrastructure.Models;
using System.Collections.Generic;

namespace Clients.Infrastructure.Interfaces
{
    public interface IClientsRepository
    {
        IEnumerable<InfrastructureClient> GetClients(int limit, int offset);

        InfrastructureClient GetClient(int clientId);

        InfrastructureClient CreateClient(InfrastructureClient client);

        void DeleteClient(int clientId);

        bool UpdateClient(int clientId, InfrastructureClient client);
    }
}
