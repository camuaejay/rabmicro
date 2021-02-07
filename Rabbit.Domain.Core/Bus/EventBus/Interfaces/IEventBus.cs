namespace Rabbit.Domain.Core.Bus.EventBus.Interfaces
{
    using System.Threading.Tasks;
    using Rabbit.Domain.Core.Commands.Base;
    using Rabbit.Domain.Core.Events.Base;
    using Rabbit.Domain.Core.Events.Interfaces;

    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>() 
            where T : Event 
            where TH : IEventHandler<T>;
    }
}
