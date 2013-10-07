using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace DemoMessages
{
    public class ZipLookupRequest:IMessage
    {
            public string zipcode { get; set; }
            public Guid UniqueId { get; set; }
            

       
    }

    public class ZipLookupResponse : IMessage
    {
        public string zipcode { get; set; }
        public Guid UniqueId { get; set; }
        public string city { get; set; }
        public string state { get; set; }

     }

}
