using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Extension.AutoMapper
{
    public class BrowserCommandProfile : Profile
    {
        public BrowserCommandProfile()
        {
            // Ignore the primary key (Id) to avoid overwriting it
            CreateMap<BrowserEntity, BrowserEntity>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<CreateBrowserDto, CreateBrowserCommand>();
            CreateMap<UpdateBrowserDto, UpdateBrowserCommand>();

            CreateMap<CreateBrowserCommand, BrowserEntity>();
            CreateMap<UpdateBrowserCommand, BrowserEntity>();
        }
    }
}
