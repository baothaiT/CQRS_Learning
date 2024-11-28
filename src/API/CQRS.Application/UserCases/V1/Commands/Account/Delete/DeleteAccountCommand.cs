using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Account
{
    public class DeleteAccountCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
