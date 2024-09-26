using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CQRS.Application.UserCases.V1.Queries;
using CQRS.Application.UserCases.V1.Commands;
using CQRS.Application.UserCases.V1.Queries.Proxy;
using CQRS.Contract.Share.DTO;
using CQRS.Application.UserCases.V1.Commands.Proxy;

namespace CQRS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProxyController : Controller
    {
        private readonly ISender _sender;
        public ProxyController(ISender sender)
        {
            _sender = sender;
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
                CreateProxyCommand command = new CreateProxyCommand
                {
                    Ip = createProxyDto.Ip,
                    Port = createProxyDto.Port,
                    User = createProxyDto.User,
                    Password = createProxyDto.Password
                };
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
                UpdateProxyCommand updateProxyCommand = new UpdateProxyCommand
                {
                    Id = id,
                    Ip = updateProxyDto.Ip,
                    Port = updateProxyDto.Port,
                    User = updateProxyDto.User,
                    Password = updateProxyDto.Password,
                    IsDelete = updateProxyDto.IsDelete
                };

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
    }
}
