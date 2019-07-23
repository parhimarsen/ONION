using System;
using Clients.Domain.Models;
using Clients.WebApi.Models;

namespace UsersApi.Mappers
{
    public static class AccountModelToDomainMapper
    {
        public static DomainAccount ToDomain(this AccountModel @this)
        {
            if(@this == null)
                throw new ArgumentNullException();
            return new DomainAccount()
            {
                NumberOfAccount = @this.NumberOfAccount,
                ClientId = @this.ClientId
            };
        }
    }
}