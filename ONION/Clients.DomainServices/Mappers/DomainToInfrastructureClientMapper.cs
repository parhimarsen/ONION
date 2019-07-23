using System;
using Clients.Domain.Models;
using Clients.Infrastructure.Models;

namespace Clients.DomainServices.Mappers
{
    public static class DomainToInfrastructureClientMapper
    {
        public static InfrastructureClient ToInfrastructure(this DomainClient @this)
        {
            if (@this == null)
                throw new ArgumentNullException();
            return new InfrastructureClient()
            {
                Name = @this.Name,
                Age = @this.Age
            };
        }
    }
}
