using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Domain.Abstractions.Repository;

namespace CQRS.Application.UserCases.V1.Commands;

public class BasedCommandHandler<T>
{
    protected readonly IRepository<T> _repository;
    public BasedCommandHandler(IRepository<T> repository)
    {
        _repository = repository;
    }
}
