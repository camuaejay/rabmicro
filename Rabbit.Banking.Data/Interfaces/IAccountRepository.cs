namespace Rabbit.Banking.Data.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Rabbit.Banking.Infrastructure.Entities;

    public interface IAccountRepository
    {
        Task<IEnumerable<AccountEntity>> GetAccounts();
    }
}
