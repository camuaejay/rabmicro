namespace Rabbit.Banking.Infrastructure.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using Rabbit.Banking.Infrastructure.Entities;
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
<<<<<<< HEAD
                    AccountTypeId = entity.AccountTypeId,
                    AccountNumber = entity.AccountNumber 
=======
                    AccountTypeId = entity.AccountTypeId
>>>>>>> ec6ec048469ed4a6230f6a210415c4455040ad38
                };
            }

            return null;
        }

        public static IEnumerable<AccountModel> AsModels(this IEnumerable<AccountEntity> entities) 
        {

            var result = new List<AccountModel>();

            result =
            entities.Select(entity => new AccountModel() {
<<<<<<< HEAD
                AccountNumber = entity.AccountNumber,
=======
>>>>>>> ec6ec048469ed4a6230f6a210415c4455040ad38
                Id = entity.Id,
                Balance = entity.Balance,
                AccountTypeId = entity.AccountTypeId
            }).ToList();

            return result;
        }
    }
}
