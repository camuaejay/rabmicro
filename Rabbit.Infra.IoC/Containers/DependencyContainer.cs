namespace Rabbit.Infra.IoC.Containers
{
    using Microsoft.Extensions.DependencyInjection;
    using Rabbit.Domain.Core.Bus.EventBus.Interfaces;
    using Rabbit.Infra.Bus;

    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services) 
        {
            services.AddTransient<IEventBus, RabbitMqEventBus>();
        }
    }
}
