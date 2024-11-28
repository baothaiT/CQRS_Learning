using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CQRS.Contract.Share.DTO;
using CQRS.Domain.Abstractions.Repository;
using AutoMapper;
using static System.Net.Mime.MediaTypeNames;

namespace CQRS.Application.UserCases.V1.Commands.Proxy;

public class UpdateProxyCommandHandler : IRequestHandler<UpdateProxyCommand, ProxyEntity>
{
    private readonly IMapper _mapper;
    private readonly IProxyRepository<ProxyEntity> _proxyRepository;
    public UpdateProxyCommandHandler(IMapper mapper, IProxyRepository<ProxyEntity> proxyRepository)
    {
        _mapper = mapper;
        _proxyRepository = proxyRepository;
    }

    public async Task<ProxyEntity> Handle(UpdateProxyCommand request, CancellationToken cancellationToken)
    {
        var proxy = await _proxyRepository.GetByIdAsync(request.Id);
        if(proxy != null)
        {
            ProxyEntity proxyEntity = new ProxyEntity();
            _mapper.Map(request, proxyEntity);
            proxyEntity.UpdateDate = DateTime.UtcNow;

            await _proxyRepository.UpdateAsync(proxyEntity);
            return proxyEntity;
        }
        throw new NotImplementedException();
    }
}
