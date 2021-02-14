namespace Rabbit.Banking.Services.Services
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Rabbit.Banking.Data.Interfaces;
    using Rabbit.Banking.Infrastructure.Messages.Requests.Account;
    using Rabbit.Banking.Infrastructure.Messages.Responses.Account;
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

        public async Task<bool> CheckExistingAccount(string accountNumber)
        {
            var result = false;

            var account = await this.accountDataGateway.GetAccount(accountNumber);

            return result;
        }

        public async Task<bool> CheckValidTransaction(string accountNumber, decimal amount)
        {
            var result = false;

            var account = await this.accountDataGateway.GetAccount(accountNumber);

            if (account != null)
            {
                result = account.Balance >= amount ? true : false;
            }

            return result;
        }

        public async Task<AccountTransferResponse> AccountTransfer(AccountTransferRequest request)
        {
            try
            {
                var response = new AccountTransferResponse();

                var canTransfer = await this.CheckAccountTransferCapability(request, response);

                if (canTransfer) 
                {
                    var from = await this.accountDataGateway.GetAccount(request.FromAccountNumber);
                    var to = await this.accountDataGateway.GetAccount(request.ToAccountNumber);

                    from.Balance = from.Balance - request.Amount;
                    to.Balance = to.Balance + request.Amount;

                    response.Account = from;

                    response.Message = "Successfully Transfered Funds.";
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new AccountServiceException(ex.Message.ToString(), ex.InnerException);
            }
        }


        private async Task<bool> CheckAccountTransferCapability(AccountTransferRequest request, AccountTransferResponse response) 
        {

            var validAccounts = await this.CheckExistingAccount(request.FromAccountNumber) &&
                                    await this.CheckExistingAccount(request.ToAccountNumber);

            var capableOfTransfer = await this.CheckValidTransaction(request.FromAccountNumber, request.Amount);

            if (validAccounts)
            {
                if (capableOfTransfer)
                {
                    response.Success = true;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Not enough Balance to transfer to another account.";
                }
            }
            else
            {
                response.Success = false;
                response.Message = "Not enough Balance to transfer to another account.";
            }

            return response.Success;
        }
    }
}
