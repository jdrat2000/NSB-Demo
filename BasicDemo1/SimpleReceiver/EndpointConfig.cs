using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using NServiceBus.Config;

namespace SimpleReceiver
{
    public class EndpointConfig:IConfigureThisEndpoint,AsA_Server,IWantCustomInitialization
    {


        public void Init()
        {
            Configure.With().DefaultBuilder().UseTransport<Msmq>();

        }
    }

}
