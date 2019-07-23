using System;
using Clients.Domain.Models;
using Clients.WebApi.Models;

namespace UsersApi.Mappers
{
    public static class DomainToClientModelMapper
    {
        public static ClientModel ToModel(this DomainClient @this)
        {
            if (@this == null)
                throw new ArgumentNullException();
            return new ClientModel()
            {
                Name = @this.Name,
                Age = @this.Age
            };
        }
    }
}