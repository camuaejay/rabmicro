namespace Rabbit.Banking.Api.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Rabbit.Banking.Api.Extensions.Account;
    using Rabbit.Banking.Infrastructure.Extensions;
    using Rabbit.Banking.Infrastructure.Messages.Requests.Account;
    using Rabbit.Banking.Infrastructure.Messages.Responses;
    using Rabbit.Banking.Infrastructure.Models;
    using Rabbit.Banking.Services.Interfaces;

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpGet]
        public async Task<ActionResult<WebResponse<IEnumerable<AccountModel>>>> GetAccounts()
        {
            var result = await this.accountService.GetAccountsAsync();

            return this.Ok(result.AsWebResponse());
        }

        [HttpPost("accountTransfer")]
        public async Task<ActionResult<WebResponse<AccountModel>>> AccountTransfer([FromBody] AccountTransferWebRequest request) 
        {
            var result = await this.accountService.AccountTransfer(request.AsRequest());

            return this.Ok(result.AsWebResponse());
        }
    }
}
