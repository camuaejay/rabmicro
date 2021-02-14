namespace Rabbit.Banking.Services.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Rabbit.Banking.Data.Interfaces;
    using Rabbit.Banking.Infrastructure.Messages.Response.Account;
    using Rabbit.Banking.Infrastructure.Models;
    using Rabbit.Banking.Services.Exceptions;
    using Rabbit.Banking.Services.Interfaces;

    public class AccountService : IAccountService
    {
        private IAccountDataGateway accountDataGateway;

        public AccountService(IAccountDataGateway accountDataGateway)
        {
            this.accountDataGateway = accountDataGateway;
        }

        public async Task<GetAccountsResponse> GetAccountsAsync()
        {
            try
            {
                var result = await this.accountDataGateway.GetAccounts();

                var response = new GetAccountsResponse();

                if (result.ToList() != null) 
                {
                    response.Accounts = result;
                    response.Success = true;
                    response.Message = "Successfully Retrieved Accounts";
                }

                return response; 
            }
            catch (Exception ex)
        {
                throw new AccountServiceException(ex.Message.ToString(), ex.InnerException);
            }  
        }
    }
}
