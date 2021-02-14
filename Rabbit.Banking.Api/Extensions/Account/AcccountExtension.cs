namespace Rabbit.Banking.Api.Extensions.Account
{
    using System.Collections.Generic;
    using Rabbit.Banking.Infrastructure.Messages.Responses;
    using Rabbit.Banking.Infrastructure.Messages.Responses.Account;
    using Rabbit.Banking.Infrastructure.Models;

    public static class AcccountExtension
    {
        public static WebResponse<IEnumerable<AccountModel>> AsWebResponse(this GetAccountsResponse response) 
        {
            var result = new WebResponse<IEnumerable<AccountModel>>(response.Accounts)
            {
                Data = response.Accounts,
                Errors = response.Errors,
                Message = response.Message,
                Success = response.Success
            };

            return result;
        }

        public static WebResponse<AccountModel> AsWebResponse(this AccountTransferResponse response)
        {
            var result = new WebResponse<AccountModel>(response.Account)
            {
                Data = response.Account,
                Errors = response.Errors,
                Message = response.Message,
                Success = response.Success
            };

            return result;
        }
    }
}
