using Clients.Domain.Models;
using Clients.Infrastructure.Models;

namespace Clients.DomainServices.Mappers
{
    public static class DomainToInfrastructureAccountMapper
    {
        public static InfrastructureAccount ToInfrastructure(this DomainAccount @this)
        {
            return new InfrastructureAccount()
            {
                ClientId = @this.ClientId,
                NumberOfAccount = @this.NumberOfAccount
            };
        }
    }
}
