using Clients.Domain.Models;
using System.Collections.Generic;

namespace Clients.Domain.Interfaces
{
    public interface IAccountsService
    {
        IEnumerable<DomainAccount> GetAccounts(SearchingGetAllFilter filter);

        DomainAccount GetAccount(int accountId);

        DomainAccount CreateAccount(DomainAccount account);

        void DeleteAccount(int accountId);

        bool UpdateAccount(int accountId, DomainAccount account);
    }
}
