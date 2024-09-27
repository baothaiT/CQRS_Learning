using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.AccountsInBrowser;
using CQRS.Application.UserCases.V1.Queries.AccountsInBrowser;
using CQRS.Contract.Share.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsInBrowserController : Controller
    {
        private readonly ISender _sender;
        private readonly IMapper _mapper;

        public AccountsInBrowserController(ISender sender, IMapper mapper)
        {
            _sender = sender;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var accountsInBrowser = await _sender.Send(new GetAllAccountsInBrowserQuery());
            return Ok(accountsInBrowser);
        }

        [HttpGet("{idAccount}/{idBrowser}")]
        public async Task<IActionResult> GetById(Guid idAccount, Guid idBrowser)
        {
            var accountsInBrowser = await _sender.Send(new GetByIdAccountsInBrowserQuery { IdAccount = idAccount, IdBrowser = idBrowser });
            if (accountsInBrowser == null)
                return NotFound();

            return Ok(accountsInBrowser);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateAccountsInBrowserDto createAccountsInBrowserDto)
        {
            try
            {
                CreateAccountsInBrowserCommand command = new CreateAccountsInBrowserCommand();

                _mapper.Map(createAccountsInBrowserDto, command);
                var response = await _sender.Send(command);

                //return CreatedAtAction(nameof(GetById), new { response }, response);
                return Ok(response);
            }
            catch
            {
                return View();
            }
        }
        [HttpPut("{idAccount}/{idBrowser}")]
        public async Task<ActionResult> Update(Guid idAccount, Guid idBrowser, [FromBody] UpdateAccountsInBrowserDto updateAccountsInBrowserDto)
        {
            try
            {
                UpdateAccountsInBrowserCommand command = new UpdateAccountsInBrowserCommand();

                updateAccountsInBrowserDto.AccountId = idAccount;
                updateAccountsInBrowserDto.BrowserId = idBrowser;
                _mapper.Map(updateAccountsInBrowserDto, command);

                var response = await _sender.Send(command);
                return Ok(response);
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
                var query = await _sender.Send(new DeleteAccountsInBrowserCommand { Id = id });
                return Ok();
            }
            catch
            {
                return NoContent();
            }
        }
    }
}
