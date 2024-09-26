using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CQRS.Contract.Share.DTO;
using CQRS.Domain.Abstractions.Repository;

namespace CQRS.Application.UserCases.V1.Commands.Proxy;

public class UpdateProxyCommandHandler : BasedProxyCommandHandler, IRequestHandler<UpdateProxyCommand, ProxyEntity>
{

    public UpdateProxyCommandHandler(IProxyRepository proxyRepository) : base(proxyRepository)
    {

    }

    public async Task<ProxyEntity> Handle(UpdateProxyCommand request, CancellationToken cancellationToken)
    {
        var proxy = await _proxyRepository.GetProxyByIdAsync(request.Id);
        if(proxy != null)
        {
            ProxyEntity proxyEntity = new ProxyEntity
            {
                Id = request.Id,
                Ip = request.Ip,
                Port = request.Port,
                User = request.User,
                Password = request.Password,
                IsDelete = request.IsDelete,
            };
            await _proxyRepository.UpdateProxyAsync(proxyEntity);
            return proxyEntity;
        }
        throw new NotImplementedException();
    }
}
