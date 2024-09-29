using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.Proxy;
using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Extension.AutoMapper
{
    public class ProxyCommandProfile : Profile
    {
        public ProxyCommandProfile()
        {
            // Ignore the primary key (Id) to avoid overwriting it
            CreateMap<ProxyEntity, ProxyEntity>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());


            CreateMap<GetProxyDto, ProxyEntity>();
            CreateMap<CreateProxyDto, CreateProxyCommand>();
            CreateMap<UpdateProxyDto, UpdateProxyCommand>();

            CreateMap<CreateProxyCommand, ProxyEntity>();
            CreateMap<UpdateProxyCommand, ProxyEntity>();
        }
    }
}
