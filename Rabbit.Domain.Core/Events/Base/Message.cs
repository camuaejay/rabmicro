namespace Rabbit.Domain.Core.Events.Base
{
    using MediatR;

    public abstract class Message : IRequest<bool>
    {
        protected Message()
        {
            MessageType = GetType().Name;
        }

        public string MessageType { get; protected set; }
    }
}
