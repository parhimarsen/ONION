using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web.Http;
using Clients.Domain.Interfaces;
using Clients.Domain.Models;
using Clients.WebApi.Models;
using UsersApi.Mappers;
using UsersApi.Models;

namespace UsersApi.Controllers
{
    [RoutePrefix("api/clients")]
    public class ClientsController : ApiController
    {
        private IClientsService _clientsService;

        public ClientsController(IClientsService clientsService)
        {
            _clientsService = clientsService;
        }

        // GET api/clients
        [HttpGet]
        [Route("")]
        public IEnumerable<ClientModel> GetAllClients([FromUri] GetAllRequest filter)
        {
            if(filter == null)
                filter = new GetAllRequest();

            var clients = _clientsService.GetClients(new SearchingGetAllFilter()
            {
                Limit = filter.Limit ?? 5,
                Offset = filter.Offset ?? 0
            });

            return clients.Select(_ => _?.ToModel());
        }

        // api/clients/1
        [HttpGet]
        [Route("{clientId:int}")]
        public ClientModel GetClient(int clientId)
        {
            return _clientsService.GetClient(clientId)?.ToModel();
        }

        // api/clients/1/accounts
        [HttpGet]
        [Route("{clientId:int}/accounts")]
        public IEnumerable<AccountModel> GetAllAccountsOfClient(int clientId)
        {
            return _clientsService.GetAccountsOfClient(clientId).Select(_ => _?.ToModel());
        }

        // api/clients/1/accounts/1
        [HttpGet]
        [Route("{clientId:int}/accounts/{accountId:int}")]
        public AccountModel GetAllAccountOfClient(int clientId, int accountId)
        {
            return _clientsService.GetAccountOfClient(clientId, accountId)?.ToModel();
        }

        // POST api/
        [HttpPost]
        [Route("createclient")]
        public ClientModel PostClient(ClientModel client)
        {
            _clientsService.CreateClient(client?.ToDomain());
            return client;
        }

        // PUT api/
        [HttpPut]
        [Route("updateclient")]
        public bool PutClient(int clientId, ClientModel client)
        {
            return _clientsService.UpdateClient(clientId, client?.ToDomain());
        }

        // DELETE api/
        [HttpDelete]
        [Route("deleteclient")]
        public void DeleteClient(int clientId)
        {
            _clientsService.DeleteClient(clientId);
        }

    }
}
