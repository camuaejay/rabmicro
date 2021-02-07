namespace Rabbit.Domain.Core.Events.Interfaces
{
    using Rabbit.Domain.Core.Events.Base;
    using System.Threading.Tasks;

    public interface IEventHandler<in TEvent> : IEventHandler where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler 
    { 
    }
}
