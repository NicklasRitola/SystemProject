﻿using ServerSide;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            SocketServer server = new SocketServer();
            server.executeServer();
        }
    }
}
