using Clients.Domain.Models;
using Clients.WebApi.Models;

namespace UsersApi.Mappers
{
    public static class ClientModelToDomainMapper
    {
        public static DomainClient ToDomain(this ClientModel @this)
        {
            return new DomainClient()
            {
                Age = @this.Age,
                Name = @this.Name
            };
        }
    }
}