namespace Rabbit.Banking.Data.DataGateways
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Rabbit.Banking.Data.Interfaces;
    using Rabbit.Banking.Infrastructure.Extensions;
    using Rabbit.Banking.Infrastructure.Models;

    public class AccountDataGateway : IAccountDataGateway
    {
        private IAccountRepository accountRepository;

        public AccountDataGateway(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public async Task<IEnumerable<AccountModel>> GetAccounts()
        {
            var result = await this.accountRepository.GetAccounts();
            return result.AsModels();
        }
    }
}