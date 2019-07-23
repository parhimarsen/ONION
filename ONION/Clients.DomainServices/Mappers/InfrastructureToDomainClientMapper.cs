using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients.Domain.Models;
using Clients.Infrastructure.Models;

namespace Clients.DomainServices.Mappers
{
    public static class InfrastructureToDomainClientMapper
    {
        public static DomainClient ToDomain(this InfrastructureClient @this)
        {
            return new DomainClient()
            {
                Name = @this.Name,
                Age = @this.Age
            };
        }
    }
}
