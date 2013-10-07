using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using DemoMessages;
using log4net;

namespace SimpleReceiver
{
    
    class SimpleOrderHandler:IHandleMessages<SimpleOrder>
    {
        public static ILog Logger = LogManager.GetLogger(typeof (SimpleOrderHandler));
        public IBus Bus { get; set; }
        public void Handle(SimpleOrder message)
        {
            
            Logger.Info("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Logger.InfoFormat("Simple Order with Guid {0} received",message.UniqueId);
        }
    }
}
