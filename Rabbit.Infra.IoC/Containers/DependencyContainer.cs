namespace Rabbit.Infra.IoC.Containers
{
    using Microsoft.Extensions.DependencyInjection;
    using Rabbit.Banking.Data.Context;
    using Rabbit.Banking.Data.DataGateways;
    using Rabbit.Banking.Data.Interfaces;
    using Rabbit.Banking.Data.Repositories;
    using Rabbit.Banking.Services.Interfaces;
    using Rabbit.Banking.Services.Services;
    using Rabbit.Domain.Core.Bus.EventBus.Interfaces;
    using Rabbit.Infra.Bus;

    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services) 
        {
            services.AddTransient<IEventBus, RabbitMqEventBus>();

            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountDataGateway, AccountDataGateway>();
            services.AddTransient<IAccountRepository, AccountRepository>();

            services.AddTransient<BankingDbContext>();
        }
    }
}
