using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Contract.Share.DTO;
using MediatR;

namespace CQRS.Application.UserCases.V1.Commands.Browser;

public class CreateBrowserCommand : CreateBrowserDto, IRequest<BrowserEntity>
{
}
