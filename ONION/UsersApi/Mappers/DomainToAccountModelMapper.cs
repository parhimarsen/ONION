using Clients.Domain.Models;
using Clients.WebApi.Models;

namespace UsersApi.Mappers
{
    public static class DomainToAccountModelMapper
    {
        public static AccountModel ToModel(this DomainAccount @this)
        {
            return new AccountModel()
            {
                NumberOfAccount = @this.NumberOfAccount,
                ClientId = @this.ClientId
            };
        }
    }
}