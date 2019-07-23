using Clients.Domain.Interfaces;
using Clients.Domain.Models;
using Clients.DomainServices.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Clients.DomainServices.Services
{
    public class AccountsService : IAccountsService
    {
        private Infrastructure.Interfaces.IUnitOfWork _repository;

        public AccountsService(Infrastructure.Interfaces.IUnitOfWork repository)
        {
            _repository = repository;
        }

        public IEnumerable<DomainAccount> GetAccounts(SearchingGetAllFilter filter)
        {
            if (filter == null)
                throw new ArgumentNullException("Filter");

            var accounts = _repository.Accounts.GetAccounts(filter.Limit, filter.Offset);

            return accounts.Select(_ => _.ToDomain());
        }

        public DomainAccount GetAccount(int accountId)
        {
            return _repository.Accounts.GetAccount(accountId).ToDomain();
        }

        public DomainAccount CreateAccount(DomainAccount account)
        {
            _repository.Accounts.CreateAccount(account.ToInfrastructure());
            return account;
        }

        public void DeleteAccount(int accountId)
        {
            _repository.Accounts.DeleteAccount(accountId);
        }

        public bool UpdateAccount(int accountId, DomainAccount account)
        {
            if (account != null)
            {
                _repository.Accounts.UpdateAccount(accountId, account.ToInfrastructure());
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
