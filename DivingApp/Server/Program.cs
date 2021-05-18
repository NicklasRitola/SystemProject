using Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates an instance of the Socket Server
            SocketServer server = new SocketServer();
            //Starts the server
            server.executeServer();

            Console.WriteLine("Server is running");
            Console.ReadLine();
        }
    }
}
