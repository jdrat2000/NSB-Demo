using System;
using NServiceBus;
using log4net;
using DemoMessages;
using NServiceBus.Features;
//using NServiceBus.Management.Retries;

namespace SelfHostedDemo
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (Program));

        static void Main(string[] args)
        {

            try
            {
                Configure.Features.Disable<SecondLevelRetries>();
                var bus = Configure.With()
                    .DefaultBuilder()
                    .XmlSerializer()
                  //  .UseTransport<msmqtransport>
                    .UnicastBus()
                    //.DisableSecondLevelRetries()
                    .DisableTimeoutManager()
                    .SendOnly();
                
                
               
                Console.WriteLine("Press enter to send a simple order");

                while (Console.ReadLine() != null)
                {

                    var ordermessage = new SimpleOrder();
                   // var ordermessage = bus.CreateInstance<SimpleOrder>();

                    ordermessage.Name = "My Order";
                    ordermessage.UniqueId = Guid.NewGuid();
                    ordermessage.OrderId = 10;
                    Console.WriteLine("Sending Order with Unique ID {0}",ordermessage.UniqueId.ToString());
                  // bus.Send("lincolndnug", ordermessage);
                   bus.Send(ordermessage);
                    
                }

            }catch(Exception ex)
            {

                throw ex;
            }





        }
    }
}
