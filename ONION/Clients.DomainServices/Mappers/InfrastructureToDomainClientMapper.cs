using Clients.Domain.Models;
using Clients.Infrastructure.Models;
using System;

namespace Clients.DomainServices.Mappers
{
    public static class InfrastructureToDomainClientMapper
    {
        public static DomainClient ToDomain(this InfrastructureClient @this)
        {
            if (@this == null)
                throw new ArgumentNullException();
            return new DomainClient()
            {
                Name = @this.Name,
                Age = @this.Age
            };
        }
    }
}
