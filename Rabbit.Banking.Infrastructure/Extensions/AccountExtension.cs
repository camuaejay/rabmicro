namespace Rabbit.Banking.Infrastructure.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using Rabbit.Banking.Infrastructure.Entities;
    using Rabbit.Banking.Infrastructure.Messages.Requests.Account;
    using Rabbit.Banking.Infrastructure.Models;

    public static class AccountExtension
    {
        public static AccountModel AsModel(this AccountEntity entity) 
        {
            if (entity != null)
            {
                return new AccountModel()
                {
                    Id = entity.Id,
                    Balance = entity.Balance,
                    AccountTypeId = entity.AccountTypeId,
                    AccountNumber = entity.AccountNumber
                };
            }

            return null;
        }

        public static IEnumerable<AccountModel> AsModels(this IEnumerable<AccountEntity> entities) 
        {

            var result = new List<AccountModel>();

            result = entities.Select(entity => new AccountModel() {
                AccountNumber = entity.AccountNumber,
                Id = entity.Id,
                Balance = entity.Balance,
                AccountTypeId = entity.AccountTypeId
            }).ToList();

            return result;
        }

        public static AccountTransferRequest AsRequest(this AccountTransferWebRequest webRequest) 
        {
            var request = new AccountTransferRequest()
            {
                Amount = webRequest.Amount,
                FromAccountNumber = webRequest.FromAccountNumber,
                ToAccountNumber = webRequest.ToAccountNumber
            };

            return request;
        }
    }
}
