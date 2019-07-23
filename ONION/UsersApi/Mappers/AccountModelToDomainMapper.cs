using Clients.Domain.Models;
using Clients.WebApi.Models;

namespace UsersApi.Mappers
{
    public static class AccountModelToDomainMapper
    {
        public static DomainAccount ToDomain(this AccountModel @this)
        {
            return new DomainAccount()
            {
                NumberOfAccount = @this.NumberOfAccount,
                ClientId = @this.ClientId
            };
        }
    }
}