﻿using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Proxy;

public class CreateProxyCommandHandler : BasedCommandHandler<ProxyEntity>, IRequestHandler<CreateProxyCommand, ProxyEntity>
{
    public CreateProxyCommandHandler(IRepository<ProxyEntity> repository): base(repository)
    {
    }
    public async Task<ProxyEntity> Handle(CreateProxyCommand request, CancellationToken cancellationToken)
    {
        ProxyEntity proxyEntity = new ProxyEntity
        {
            Id = Guid.NewGuid(),
            Ip = request.Ip,
            Port = request.Port,
            User = request.User,
            Password = request.Password

        };
        await _repository.AddAsync(proxyEntity);
        return proxyEntity;
    }
}