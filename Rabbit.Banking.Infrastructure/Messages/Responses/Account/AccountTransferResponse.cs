namespace Rabbit.Banking.Infrastructure.Messages.Responses.Account
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Rabbit.Banking.Infrastructure.Entities;
    using Rabbit.Banking.Infrastructure.Models;

    public class AccountTransferResponse : BaseResponse
    {
        public AccountTransferResponse()
        {
        }

        public AccountModel Account { get; set; }
    }
}
