namespace Rabbit.Domain.Core.Events.Base
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Event
    {
        protected Event()
        {
            TimeStamp = DateTime.UtcNow;
        }

        public DateTime TimeStamp { get; protected set; }
    }
}
