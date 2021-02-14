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
<<<<<<< HEAD

        public string AccountNumber { get; set; }
=======
>>>>>>> ec6ec048469ed4a6230f6a210415c4455040ad38
    }
}
