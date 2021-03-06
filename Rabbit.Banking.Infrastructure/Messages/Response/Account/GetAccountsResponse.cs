﻿namespace Rabbit.Banking.Infrastructure.Messages.Response.Account
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Rabbit.Banking.Infrastructure.Models;

    public class GetAccountsResponse : BaseResponse
    {
        public GetAccountsResponse()
        {
        }

        public IEnumerable<AccountModel> Accounts { get; set; }
    }
}
