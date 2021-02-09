namespace Rabbit.Banking.Services.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Rabbit.Banking.Infrastructure.Messages.Response.Account;
    using Rabbit.Banking.Infrastructure.Models;

    public interface IAccountService
    {
        Task<GetAccountsResponse> GetAccountsAsync();
    }
}
