using Clients.Domain.Models;
using Clients.WebApi.Models;

namespace UsersApi.Mappers
{
    public static class DomainToClientModelMapper
    {
        public static ClientModel ToModel(this DomainClient @this)
        {
            return new ClientModel()
            {
                Name = @this.Name,
                Age = @this.Age
            };
        }
    }
}