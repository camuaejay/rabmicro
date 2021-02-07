namespace Rabbit.Infra.Bus
{
    using MediatR;
    using Newtonsoft.Json;
    using Rabbit.Domain.Core.Bus.EventBus.Interfaces;
    using Rabbit.Domain.Core.Commands.Base;
    using Rabbit.Domain.Core.Events.Base;
    using Rabbit.Domain.Core.Events.Interfaces;
    using RabbitMQ.Client;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class RabbitMqEventBus : IEventBus
    {
        private readonly IMediator mediator;
        private readonly Dictionary<string, List<Type>> handlers;
        private readonly List<Type> eventTypes;

        public RabbitMqEventBus(IMediator mediator)
        {
            this.mediator = mediator;
            this.handlers = new Dictionary<string, List<Type>>();
            this.eventTypes = new List<Type>();
        }

        public void Publish<T>(T @event) where T : Event
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };

            using (var connection = factory.CreateConnection()) 
            {
                using (var channel = connection.CreateModel()) 
                {
                    var eventName = @event.GetType().Name;

                    channel.QueueDeclare(eventName, false, false, false, null);

                    var message = JsonConvert.SerializeObject(@event);

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish("", eventName, null, body);
                }
            }
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return mediator.Send(command);
        }

        public void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var eventName = typeof(T).Name;
                    var handlerType = typeof(TH);

                    if (!eventTypes.Contains(typeof(T)))
                    {
                        this.eventTypes.Add(typeof(T));
                    }


                    if (!handlers.ContainsKey(eventName))
                    {
                        handlers.Add(eventName, new List<Type>());
                    }

                    if (handlers[eventName].Any(s => s.GetType() == handlerType))
                    {
                        throw new ArgumentException("Handler Type Already registered");
                    }

                    handlers[eventName].Add(handlerType);

                    channel.QueueDeclare(eventName, false, false, false, null);

                    //var consumer = Consumer

                    //var message = JsonConvert.SerializeObject(@event);

                    //var body = Encoding.UTF8.GetBytes(message);

                    //channel.BasicPublish("", eventName, null, body);
                }
            }
        }
    }
}
