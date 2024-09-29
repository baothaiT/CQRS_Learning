using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CQRS.Application.UserCases.V1.Queries.Proxy;
using CQRS.Contract.Share.DTO;
using CQRS.Application.UserCases.V1.Commands.Proxy;
using AutoMapper;
using CQRS.Contract.Share.Models;
using CQRS.Application.Services.Interface;
using CQRS.Domain.Entities;

namespace CQRS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProxyController : Controller
    {
        private readonly ISender _sender;
        private readonly IMapper _mapper;
        private readonly IProxyService _proxyService;
        public ProxyController(ISender sender, IMapper mapper, IProxyService proxyService)
        {
            _sender = sender;
            _mapper = mapper;
            _proxyService = proxyService;
        }
        // GET: ProxyController
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var proxy = await _sender.Send(new GetAllProxyQuery());
            return Ok(proxy);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var product = await _sender.Send(new GetProxyByIdQuery { Id = id });
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        // POST: ProxyController/Create
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateProxyDto createProxyDto)
        {
            try
            {
                CreateProxyCommand command = new CreateProxyCommand();

                _mapper.Map(createProxyDto, command);
                var response = await _sender.Send(command);

                //return CreatedAtAction(nameof(GetById), new { response }, response);
                return Ok(response);
            }
            catch
            {
                return View();
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, [FromBody] UpdateProxyDto updateProxyDto)
        {
            try
            {
                UpdateProxyCommand updateProxyCommand = new UpdateProxyCommand();

                updateProxyDto.Id = id;
                _mapper.Map(updateProxyDto, updateProxyCommand);

                var proxy = await _sender.Send(updateProxyCommand);
                return Ok(proxy);
            }
            catch
            {
                return NoContent();
            }
        }

        // POST: ProxyController/Delete/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                var query = await _sender.Send(new DeleteProxyCommand { Id = id });
                return Ok();
            }
            catch
            {
                return NoContent();
            }
        }

        [HttpPost("CheckProxies")]
        public async Task<IActionResult> CheckProxies([FromBody] List<GetProxyDto> proxies)
        {
            for (int i = 0; i < proxies.Count(); i++)
            {
                proxies[i] = await _proxyService.IsProxyWorking(proxies[i]);
            }
            return Ok(proxies);
        }

    }
}
