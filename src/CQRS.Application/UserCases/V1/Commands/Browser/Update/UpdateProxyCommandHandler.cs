using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CQRS.Contract.Share.DTO;
using CQRS.Domain.Abstractions.Repository;

namespace CQRS.Application.UserCases.V1.Commands.Browser;

public class UpdateBrowserCommandHandler : BasedCommandHandler<BrowserEntity>, IRequestHandler<UpdateBrowserCommand, BrowserEntity>
{

    public UpdateBrowserCommandHandler(IRepository<BrowserEntity> repository) : base(repository)
    {

    }

    public async Task<BrowserEntity> Handle(UpdateBrowserCommand request, CancellationToken cancellationToken)
    {
        var browser = await _repository.GetByIdAsync(request.Id);
        if(browser != null)
        {
            BrowserEntity browserEntity = new BrowserEntity
            {
                Id = request.Id,
                Name = request.Name,
                Path = request.Path,
                IsStatus = request.IsStatus,
                CreateDate = request.CreateDate,
                IsDelete = request.IsDelete

            };
            await _repository.UpdateAsync(browserEntity);
            return browserEntity;
        }
        throw new NotImplementedException();
    }
}
