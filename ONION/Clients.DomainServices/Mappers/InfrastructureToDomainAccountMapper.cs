﻿using System;
using Clients.Domain.Models;
using Clients.Infrastructure.Models;

namespace Clients.DomainServices.Mappers
{
    public static class InfrastructureToDomainAccountMapper
    {
        public static DomainAccount ToDomain(this InfrastructureAccount @this)
        {
            if (@this == null)
                throw new ArgumentNullException();
            return new DomainAccount()
            {
                ClientId = @this.ClientId,
                NumberOfAccount = @this.NumberOfAccount
            };
        }
    }
}
