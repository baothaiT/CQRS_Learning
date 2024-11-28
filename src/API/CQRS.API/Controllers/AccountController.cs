using AutoMapper;
using CQRS.Application.UserCases.V1.Queries.Account;
using CQRS.Application.UserCases.V1.Commands.Account;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using CQRS.Contract.Share.DTO;
using CQRS.Contract.Share.DTO._JoinDTO;
using CQRS.Domain.Entities;

namespace CQRS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly ISender _sender;
        private readonly IMapper _mapper;

        public AccountController(ISender sender, IMapper mapper)
        {
            _sender = sender;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var account = await _sender.Send(new GetAllAccountQuery());
            return Ok(account);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var account = await _sender.Send(new GetAccountByIdQuery { Id = id });
            if (account == null)
                return NotFound();

            return Ok(account);
        }

        [HttpGet("GetBrowserByAccountId/{id}")]
        public async Task<IActionResult> GetBrowserByAccountId(Guid id)
        {
            var account = await _sender.Send(new GetBrowserByAccountIdQuery { AccountId = id });
            if (account == null)
                return NotFound();

            return Ok(account);
        }

        [HttpGet("GetProxyAndBrowserByAccountId/{id}")]
        public async Task<IActionResult> GetProxyAndBrowserByAccountId(Guid id)
        {
            var account = await _sender.Send(new GetProxyAndBrowserByAccountIdQuery { AccountId = id });
            if (account == null)
                return NotFound();

            return Ok(account);
        }

        [HttpGet("GetAllProxyAndBrowserFromAllAccount")]
        public async Task<IActionResult> GetAll_ProxyAndBrowserByAccountId()
        {
            List<Proxy_Account_Browser_DTO> proxy_Account_Browser_DTOs = new List<Proxy_Account_Browser_DTO>();
            var accountResponse = await _sender.Send(new GetAllAccountQuery());
            
            if (accountResponse.Any())
            {
                List<AccountEntity> accounts = accountResponse.ToList();
                foreach (var account in accounts)
                {
                    var proxy_browser_ByAccountIds = await _sender.Send(new GetProxyAndBrowserByAccountIdQuery { AccountId = account.Id });
                    if(proxy_browser_ByAccountIds != null  && proxy_browser_ByAccountIds.Any())
                    {
                        proxy_Account_Browser_DTOs.AddRange(proxy_browser_ByAccountIds);
                    }
                }
            }          
            return Ok(proxy_Account_Browser_DTOs);
        }


        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateAccountsDto createAccountsDto)
        {
            try
            {
                CreateAccountCommand command = new CreateAccountCommand();

                _mapper.Map(createAccountsDto, command);
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
        public async Task<ActionResult> Update(Guid id, [FromBody] UpdateAccountsDto updateAccountDto)
        {
            try
            {
                UpdateAccountCommand command = new UpdateAccountCommand();

                updateAccountDto.Id = id;
                _mapper.Map(updateAccountDto, command);

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
                var query = await _sender.Send(new DeleteAccountCommand { Id = id });
                return Ok();
            }
            catch
            {
                return NoContent();
            }
        }
    }
}
