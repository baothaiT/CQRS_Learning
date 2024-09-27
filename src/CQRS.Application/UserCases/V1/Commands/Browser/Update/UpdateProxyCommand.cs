using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CQRS.Domain.Entities;
using CQRS.Contract.Share.DTO;

namespace CQRS.Application.UserCases.V1.Commands.Browser;

public class UpdateBrowserCommand : UpdateBrowserDto, IRequest<BrowserEntity>
{
    public Guid Id { get; set; }
}
