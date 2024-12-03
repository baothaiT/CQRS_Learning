﻿using AutoMapper;
using CQRS.Application.Services.Interface;
using CQRS.Application.UserCases.V1.Commands.HistoryOrderTrading;
using CQRS.Application.UserCases.V1.Queries.Account;
using CQRS.Application.UserCases.V1.Queries.HistoryOrderTrading;
using CQRS.Contract.Share.DTO;
using CQRS.Contract.Share.DTO.HistoryOrderTrading;
using CQRS.Contract.Share.Enum;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRS.API.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class HistoryOrderTradingController : Controller
    {
        private readonly ISender _sender;
        private readonly IMapper _mapper;
        public HistoryOrderTradingController(ISender sender, IMapper mapper)
        {
            _sender = sender;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var historyOrderTrading = await _sender.Send(new GetAllHistoryOrderTradingQuery());
            return Ok(historyOrderTrading);
        }

        [HttpGet("/byparam")]
        public async Task<IActionResult> GetByParamAsync([FromQuery] 
            string? side, 
            string? startDateTime, 
            string? endDateTime,
            string? symbol_Prefix,
            string? symbol_Suffix,
            IsResovlveEnum IsResovlve
            )
        {
            GetByParamHistoryOrderTradingQuery getByParamHistoryOrderTradingQuery = new GetByParamHistoryOrderTradingQuery();
            getByParamHistoryOrderTradingQuery.Side = side;
            getByParamHistoryOrderTradingQuery.startDatetime = !string.IsNullOrEmpty(startDateTime) ? DateTime.Parse(startDateTime) : null;
            getByParamHistoryOrderTradingQuery.endDatetime = !string.IsNullOrEmpty(endDateTime) ? DateTime.Parse(endDateTime) : null;
            getByParamHistoryOrderTradingQuery.Symbol_Prefix = symbol_Prefix;
            getByParamHistoryOrderTradingQuery.Symbol_Suffix = symbol_Suffix;
            getByParamHistoryOrderTradingQuery.IsResovlve = IsResovlve;


            var historyOrderTrading = await _sender.Send(getByParamHistoryOrderTradingQuery);
            return Ok(historyOrderTrading);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateHistoryOrderTradingDTO createHistoryOrderTradingDTO)
        {
            CreateHistoryOrderTradingCommand historyOrderTradingRequest = new CreateHistoryOrderTradingCommand();
            _mapper.Map(createHistoryOrderTradingDTO, historyOrderTradingRequest);
            var historyOrderTrading = await _sender.Send(historyOrderTradingRequest);
            return Ok(historyOrderTrading);
        }

        [HttpPut("/changeIsResolve/{id}")]
        public async Task<IActionResult> ChangeIsResolve(Guid id)
        {
            ChangeIsRolveCommand changeIsRolveCommand = new ChangeIsRolveCommand()
            {
                Id = id
            };
            await _sender.Send(changeIsRolveCommand);
            return Ok();
        }
    }
}