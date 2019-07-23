using Clients.Domain.Interfaces;
using Clients.Domain.Models;
using Clients.DomainServices.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clients.DomainServices.Services
{
    public class ClientsService : IClientsService
    {
        private Infrastructure.Interfaces.IUnitOfWork _repository;

        public ClientsService(Infrastructure.Interfaces.IUnitOfWork repository)
        {
            _repository = repository;
        }

        public IEnumerable<DomainClient> GetClients(SearchingGetAllFilter filter)
        {
            if (filter == null)
                throw new ArgumentNullException("Filter");

            var clients = _repository.Clients.GetClients(filter.Limit, filter.Offset);

            return clients.Select(_ => _?.ToDomain());
        }

        public DomainClient GetClient(int clientId)
        {
            return _repository.Clients.GetClient(clientId)?.ToDomain();
        }

        public IEnumerable<DomainAccount> GetAccountsOfClient(int clientId)
        {
            return _repository.Accounts.GetAccountsOfClient(clientId).Select(_ => _?.ToDomain());
        }

        public DomainAccount GetAccountOfClient(int clientId, int accountId)
        {
            return _repository.Accounts.GetAccountOfClient(clientId, accountId)?.ToDomain();
        }

        public DomainClient CreateClient(DomainClient client)
        {
            _repository.Clients.CreateClient(client?.ToInfrastructure());
            return client;
        }

        public void DeleteClient(int clientId)
        {
            _repository.Clients.DeleteClient(clientId);
        }

        public bool UpdateClient(int clientId, DomainClient client)
        {
            if (client != null)
            {
                _repository.Clients.UpdateClient(clientId, client.ToInfrastructure());
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
