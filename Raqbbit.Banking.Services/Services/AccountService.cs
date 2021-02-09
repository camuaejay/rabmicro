namespace Rabbit.Banking.Services.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Rabbit.Banking.Data.Interfaces;
    using Rabbit.Banking.Infrastructure.Models;
    using Rabbit.Banking.Services.Interfaces;

    public class AccountService : IAccountService
    {
        private IAccountDataGateway accountDataGateway;

        public AccountService(IAccountDataGateway accountDataGateway)
        {
            this.accountDataGateway = accountDataGateway;
        }

        public async Task<IEnumerable<AccountModel>> GetAccountsAsync()
        {
            return await this.accountDataGateway.GetAccounts();
        }
    }
}
