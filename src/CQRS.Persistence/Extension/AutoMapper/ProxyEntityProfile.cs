using AutoMapper;
using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Persistence.Etension.AutoMapper
{
    public class ProxyEntityProfile : Profile
    {
        public ProxyEntityProfile()
        {
            // Ignore the primary key (Id) to avoid overwriting it
            CreateMap<ProxyEntity, ProxyEntity>();
        }
    }
}
