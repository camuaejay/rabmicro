namespace Rabbit.Banking.Data.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Rabbit.Banking.Infrastructure.Models;

    public interface IAccountDataGateway
    {
        Task<IEnumerable<AccountModel>> GetAccounts();

        Task<AccountModel> GetAccount(string accountNumber);
    }
}
