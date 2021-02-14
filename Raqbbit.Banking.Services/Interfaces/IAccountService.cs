namespace Rabbit.Banking.Services.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Rabbit.Banking.Infrastructure.Messages.Requests.Account;
    using Rabbit.Banking.Infrastructure.Messages.Responses.Account;
    using Rabbit.Banking.Infrastructure.Models;

    public interface IAccountService
    {
        Task<GetAccountsResponse> GetAccountsAsync();

        Task<AccountTransferResponse> AccountTransfer(AccountTransferRequest request);

        Task<bool> CheckExistingAccount(string accountNumber);

        Task<bool> CheckValidTransaction(string accountNumber, decimal amount);
    }
}
