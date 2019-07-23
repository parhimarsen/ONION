using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Clients.Domain.Interfaces;
using Clients.Domain.Models;
using Clients.WebApi.Models;
using UsersApi.Mappers;
using UsersApi.Models;

namespace UsersApi.Controllers
{
    [RoutePrefix("api/accounts")]
    public class AccountsController : ApiController
    {
        private IAccountsService _accountsService;

        public AccountsController(IAccountsService accountsService)
        {
            _accountsService = accountsService;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<AccountModel> GetAllAccounts([FromUri] GetAllRequest filter)
        {
            if(filter == null)
                filter = new GetAllRequest();

            var accounts = _accountsService.GetAccounts(new SearchingGetAllFilter()
            {
                Limit = filter.Limit ?? 5,
                Offset = filter.Offset ?? 0
            });

            return accounts.Select(_ => _?.ToModel());
        }

        [HttpGet]
        [Route("{accountId:int}")]
        public AccountModel GetAccount(int accountId)
        {
            return _accountsService.GetAccount(accountId)?.ToModel();
        }

        [HttpPost]
        [Route("createaccount")]
        public AccountModel CreateAccount(AccountModel account)
        {
            _accountsService.CreateAccount(account?.ToDomain());
            return account;
        }

        [HttpDelete]
        [Route("deleteaccount")]
        public void RemoveAccount(int accountId)
        {
            _accountsService.DeleteAccount(accountId);
        }

        [HttpPut]
        [Route("updateaccount")]
        public bool PutAccount(int accountId, AccountModel account)
        {
            return _accountsService.UpdateAccount(accountId, account?.ToDomain());
        }
    }
}
