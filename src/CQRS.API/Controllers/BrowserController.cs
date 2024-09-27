using CQRS.Application.UserCases.V1.Queries.Proxy;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using CQRS.Application.UserCases.V1.Commands.Browser;
using CQRS.Application.UserCases.V1.Queries.Browser;
using CQRS.Application.UserCases.V1.Commands.Proxy;
using CQRS.Contract.Share.DTO;
using System.Net.NetworkInformation;

namespace CQRS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrowserController : Controller
    {
        private readonly ISender _sender;

        public BrowserController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var proxy = await _sender.Send(new GetAllBrowserQuery());
            return Ok(proxy);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var browser = await _sender.Send(new GetBrowserByIdQuery { Id = id });
            if (browser == null)
                return NotFound();

            return Ok(browser);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateBrowserDto createBrowserDto)
        {
            try
            {
                CreateBrowserCommand command = new CreateBrowserCommand
                {
                    Name = createBrowserDto.Name,
                    Path = createBrowserDto.Path,
                    IsStatus = createBrowserDto.IsStatus,
                    CreateDate = createBrowserDto.CreateDate
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
        public async Task<ActionResult> Update(Guid id, [FromBody] UpdateBrowserDto updateBrowserDto)
        {
            try
            {
                UpdateBrowserCommand command = new UpdateBrowserCommand
                {
                    Id = id,
                    Name = updateBrowserDto.Name,
                    Path = updateBrowserDto.Path,
                    IsStatus = updateBrowserDto.IsStatus,
                    CreateDate = updateBrowserDto.CreateDate,
                    IsDelete = updateBrowserDto.IsDelete
                };

                var browser = await _sender.Send(command);
                return Ok(browser);
            }
            catch
            {
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                var query = await _sender.Send(new DeleteBrowserCommand { Id = id });
                return Ok();
            }
            catch
            {
                return NoContent();
            }
        }
    }
}
