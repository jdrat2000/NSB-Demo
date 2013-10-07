using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace DemoMessages
{
 [TimeToBeReceived("00:03:00")] 
    public class SimpleOrder:IMessage
    {
        public long OrderId { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public Guid UniqueId { get; set; }

    }
}
