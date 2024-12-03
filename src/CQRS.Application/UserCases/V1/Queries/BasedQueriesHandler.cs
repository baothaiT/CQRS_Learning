using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries
{
    public class BasedQueriesHandler<T>
    {
        protected readonly IRepository<T> _repository;
        public BasedQueriesHandler(IRepository<T> repository)
        {
            _repository = repository;
        }
    }
}
