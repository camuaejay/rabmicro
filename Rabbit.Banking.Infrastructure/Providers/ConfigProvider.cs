namespace Rabbit.Banking.Infrastructure.Providers
{
    using Microsoft.Extensions.Configuration;


    public class ConnectionConfigProvider
    {
        private IConfiguration configuration;

        public ConnectionConfigProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.BankingDBConnection = this.configuration.GetValue<string>("Connection:BankingDbConnectionString");
        }

        public string BankingDBConnection { get; set; }
    }
}
