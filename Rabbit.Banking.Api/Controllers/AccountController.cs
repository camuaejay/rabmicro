namespace Rabbit.Banking.Api.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Rabbit.Banking.Api.Extensions.Account;
    using Rabbit.Banking.Infrastructure.Messages.Response;
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


        [HttpGet()]
        public async Task<ActionResult<WebResponse<IEnumerable<AccountModel>>>> GetAccounts()
        {
            var result = await this.accountService.GetAccountsAsync();

            return Ok(result.AsWebResponse());
        }
    }
}
