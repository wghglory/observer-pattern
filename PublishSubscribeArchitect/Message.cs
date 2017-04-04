using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribeArchitect
{
    public class Message
    {
        public string Topic { get; set; }
        public string Detail { get; set; }
    }
}
