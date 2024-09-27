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

public class UpdateProxyCommandHandler : BasedCommandHandler<ProxyEntity>, IRequestHandler<UpdateProxyCommand, ProxyEntity>
{
    private readonly IMapper _mapper;
    public UpdateProxyCommandHandler(IRepository<ProxyEntity> repository, IMapper mapper) : base(repository)
    {
        _mapper = mapper;
    }

    public async Task<ProxyEntity> Handle(UpdateProxyCommand request, CancellationToken cancellationToken)
    {
        var proxy = await _repository.GetByIdAsync(request.Id);
        if(proxy != null)
        {
            ProxyEntity proxyEntity = new ProxyEntity();
            _mapper.Map(request, proxyEntity);

            await _repository.UpdateAsync(proxyEntity);
            return proxyEntity;
        }
        throw new NotImplementedException();
    }
}
