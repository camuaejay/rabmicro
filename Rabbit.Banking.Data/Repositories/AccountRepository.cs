namespace Rabbit.Banking.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Rabbit.Banking.Data.Context;
    using Rabbit.Banking.Data.Interfaces;
    using Rabbit.Banking.Infrastructure.Entities;

    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext bankingDbContext;

        public AccountRepository(BankingDbContext bankingDbContext)
        {
            this.bankingDbContext = bankingDbContext;
        }

        public async Task<AccountEntity> GetAccount(string accountNumber)
        {
            return await bankingDbContext.Accounts.Select(a => a).Where(x => x.AccountNumber == accountNumber).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<AccountEntity>> GetAccounts()
        {
            return await bankingDbContext.Accounts.Select(a => a).ToListAsync();
        }
    }
}