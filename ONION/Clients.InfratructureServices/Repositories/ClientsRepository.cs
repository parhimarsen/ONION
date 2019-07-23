using Clients.Infrastructure.Interfaces;
using Clients.Infrastructure.Models;
using System.Collections.Generic;
using System.Linq;

namespace Clients.InfratructureServices.Repositories
{
    public class ClientsRepository : IClientsRepository
    {
        public IList<InfrastructureClient> Database = new List<InfrastructureClient>()
        {
            new InfrastructureClient() {Id = 1, Name = "Arseny", Age = 21},
            new InfrastructureClient() {Id = 2, Name = "Pavel", Age = 25},
            new InfrastructureClient() {Id = 3, Name = "Ales", Age = 22},
            new InfrastructureClient() {Id = 4, Name = "Mark", Age = 22},
            new InfrastructureClient() {Id = 5, Name = "Anton", Age = 22},
            new InfrastructureClient() {Id = 6, Name = "Masha", Age = 19},
            new InfrastructureClient() {Id = 7, Name = "Alexandr", Age = 37}
        };

        public IEnumerable<InfrastructureClient> GetClients(int limit, int offset)
        {
            IEnumerable<InfrastructureClient> clients;

            if (offset < Database.Count)
            {
                clients = Database.Skip(offset).Take(limit);
            }
            else
            {
                clients = Enumerable.Empty<InfrastructureClient>();
            }

            return clients;
        }

        public InfrastructureClient GetClient(int clientId)
        {
            return Database.FirstOrDefault(_ => _.Id == clientId);
        }

        public InfrastructureClient CreateClient(InfrastructureClient client)
        {
            client.Id = Database.Count + 1;
            Database.Add(client);
            return client;
        }

        public void DeleteClient(int clientId)
        {
            InfrastructureClient deleteClient = GetClient(clientId);

            if (deleteClient != null)
            {
                Database.Remove(deleteClient);
            }
        }

        public bool UpdateClient(int clientId, InfrastructureClient client)
        {
            InfrastructureClient storedClient = GetClient(clientId);

            if (storedClient != null)
            {
                storedClient.Name = client.Name;
                storedClient.Age = client.Age;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
