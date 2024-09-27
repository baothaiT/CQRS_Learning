using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CQRS.Application.UserCases.V1.Commands.Browser;

public class CreateBrowserCommandHandler : BasedCommandHandler<BrowserEntity>, IRequestHandler<CreateBrowserCommand, BrowserEntity>
{
    public CreateBrowserCommandHandler(IRepository<BrowserEntity> repository): base(repository)
    {
    }
    public async Task<BrowserEntity> Handle(CreateBrowserCommand request, CancellationToken cancellationToken)
    {
        BrowserEntity BrowserEntity = new BrowserEntity
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Path = request.Path,
            IsStatus = request.IsStatus,
            CreateDate = request.CreateDate,
            IsDelete = false

        };
        await _repository.AddAsync(BrowserEntity);
        return BrowserEntity;
    }
}
