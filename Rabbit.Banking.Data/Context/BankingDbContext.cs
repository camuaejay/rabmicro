namespace Rabbit.Banking.Data.Context
{
    using Microsoft.EntityFrameworkCore;
    using Rabbit.Banking.Infrastructure.Entities;

    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AccountEntity> Accounts { get; set; }
    }
}
