﻿namespace Rabbit.Banking.Infrastructure.Models
{
    using System;

    public class AccountModel
    {
        public Guid Id { get; set; }

        public int AccountTypeId { get; set; }

        public string AccountNumber { get; set; }

        public decimal Balance { get; set; }
    }
}
