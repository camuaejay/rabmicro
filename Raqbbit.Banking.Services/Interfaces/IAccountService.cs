namespace Rabbit.Banking.Services.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Rabbit.Banking.Infrastructure.Models;

    public interface IAccountService
    {
        Task<IEnumerable<AccountModel>> GetAccountsAsync();
    }
}
