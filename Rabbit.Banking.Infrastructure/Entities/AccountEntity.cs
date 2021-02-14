using System;

namespace Rabbit.Banking.Infrastructure.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Account")]
    public class AccountEntity
    {
        public Guid Id { get; set; }

        public int AccountTypeId { get; set; }

        public decimal Balance { get; set; }

        public string AccountNumber { get; set; }
    }
}
