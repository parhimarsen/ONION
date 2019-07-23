using Clients.Infrastructure.Interfaces;
using Clients.Infrastructure.Models;
using System.Collections.Generic;
using System.Linq;

namespace Clients.InfratructureServices.Repositories
{
    public class AccountsRepository : IAccountsRepository
    {
        public IList<InfrastructureAccount> Database = new List<InfrastructureAccount>()
        {
            new InfrastructureAccount() {Id  = 1, NumberOfAccount = "123", ClientId = 1},
            new InfrastructureAccount() {Id  = 2, NumberOfAccount = "555", ClientId = 2},
            new InfrastructureAccount() {Id  = 3, NumberOfAccount = "212", ClientId = 3},
            new InfrastructureAccount() {Id  = 4, NumberOfAccount = "2124", ClientId = 3},
            new InfrastructureAccount() {Id  = 5, NumberOfAccount = "111", ClientId = 4},
            new InfrastructureAccount() {Id  = 6, NumberOfAccount = "687", ClientId = 4},
            new InfrastructureAccount() {Id  = 7, NumberOfAccount = "911", ClientId = 4},
            new InfrastructureAccount() {Id  = 8, NumberOfAccount = "33333", ClientId = 5},
            new InfrastructureAccount() {Id  = 9, NumberOfAccount = "3288", ClientId = 6}
        };

        public IEnumerable<InfrastructureAccount> GetAccounts(int limit, int offset)
        {
            IEnumerable<InfrastructureAccount> accounts;

            if (offset < Database.Count)
            {
                accounts = Database.Skip(offset).Take(limit);
            }
            else
            {
                accounts = Enumerable.Empty<InfrastructureAccount>();
            }

            return accounts;
        }

        public InfrastructureAccount GetAccount(int accountId)
        {
            return Database.FirstOrDefault(_ => _.Id == accountId);
        }

        public IEnumerable<InfrastructureAccount> GetAccountsOfClient(int clientId)
        {
            return Database.Where(_ => _.ClientId == clientId);
        }

        public InfrastructureAccount GetAccountOfClient(int clientId, int accountId)
        {
            return GetAccountsOfClient(clientId).FirstOrDefault(_ => _.Id == accountId);
        }

        public InfrastructureAccount CreateAccount(InfrastructureAccount account)
        {
            account.Id = Database.Count + 1;
            Database.Add(account);
            return account;
        }

        public void DeleteAccount(int accountId)
        {
            InfrastructureAccount deleteAccount = GetAccount(accountId);

            if (deleteAccount != null)
            {
                Database.Remove(deleteAccount);
            }
        }

        public bool UpdateAccount(int accountId, InfrastructureAccount account)
        {
            InfrastructureAccount storedAccount = GetAccount(accountId);

            if (storedAccount != null)
            {
                storedAccount.NumberOfAccount = account.NumberOfAccount;
                storedAccount.ClientId = account.ClientId;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
