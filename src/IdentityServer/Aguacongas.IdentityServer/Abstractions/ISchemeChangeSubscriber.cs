﻿using System.Threading;
using System.Threading.Tasks;

namespace Aguacongas.IdentityServer.Abstractions
{
    public interface ISchemeChangeSubscriber
    {
        Task SubscribeAsync(CancellationToken cancellationToken);
        Task UnSubscribeAsync(CancellationToken cancellationToken);
    }
}