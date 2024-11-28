using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.HistoryOrderTrading;
using CQRS.Application.UserCases.V1.Commands.Proxy;
using CQRS.Contract.Share.DTO.HistoryOrderTrading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Extension.AutoMapper;

public class HistoryOrderTradingProfile : Profile
{
    public HistoryOrderTradingProfile()
    {
        // Ignore the primary key (Id) to avoid overwriting it
        CreateMap<HistoryOrderTradingEntity, HistoryOrderTradingEntity>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<HistoryOrderTradingEntity, GetHistoryOrderTradingDTO>();

        CreateMap<HistoryOrderTradingEntity, CreateHistoryOrderTradingDTO>();
        //CreateMap<HistoryOrderTradingEntity, UpdateHistoryOrderTradingDTO>();

        //CreateMap<GetProxyDto, ProxyEntity>();
        CreateMap<CreateHistoryOrderTradingDTO, CreateHistoryOrderTradingCommand>();
        //CreateMap<UpdateProxyDto, UpdateProxyCommand>();

        CreateMap<CreateHistoryOrderTradingCommand, HistoryOrderTradingEntity>();
        //CreateMap<UpdateProxyCommand, ProxyEntity>();
    }
}
