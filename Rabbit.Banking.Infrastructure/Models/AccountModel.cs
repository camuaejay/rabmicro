namespace Rabbit.Banking.Infrastructure.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class AccountModel
    {
        public Guid Id { get; set; }

        public int AccountTypeId { get; set; }

        public decimal Balance { get; set; }
    }
}
