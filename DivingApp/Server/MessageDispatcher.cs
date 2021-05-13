using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Server
{
    public class MessageDispatcher
    {
        public void DispatchMessage(Message message)
        {
            Console.WriteLine("This was a request!");
        }
    }
}