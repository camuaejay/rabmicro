namespace Rabbit.Domain.Core.Commands.Base
{
    using Rabbit.Domain.Core.Events.Base;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Command : Message
    {
        protected Command()
        {
            TimeStamp = DateTime.UtcNow;
        }

        public DateTime TimeStamp { get; protected set; }
    }
}
