﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Server
{
    public class MessageDispatcher
    {
        //Finds the type of the message and sends it to the appropriate handler method
        public void DispatchMessage(Request request)
        {
            
        }
        
        public void DispatchMessage<T>(T request)
        {
            //Finds the type of the message and sends it to the appropriate handler method
        }
    }
}