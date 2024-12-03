using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Proxy;

public class CreateProxyCommandHandler : IRequestHandler<CreateProxyCommand, ProxyEntity>
{
    private readonly IProxyRepository<ProxyEntity> _proxyRepository;
    public CreateProxyCommandHandler(IProxyRepository<ProxyEntity> proxyRepository)
    {
        _proxyRepository = proxyRepository;
    }
    public async Task<ProxyEntity> Handle(CreateProxyCommand request, CancellationToken cancellationToken)
    {
        ProxyEntity proxyEntity = new ProxyEntity
        {
            Id = Guid.NewGuid(),
            Ip = request.Ip,
            Port = request.Port,
            User = request.User,
            IsStatus = request.IsStatus,
            Password = request.Password,
            IsMigration = request.IsMigration,
            CreateDate = DateTime.UtcNow,
            UpdateDate = null,
            CheckLiveDate = null
        };
        await _proxyRepository.AddAsync(proxyEntity);
        return proxyEntity;
    }
}
