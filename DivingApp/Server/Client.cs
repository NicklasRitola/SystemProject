using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Client
    {
        //Class used to store clients with their connected socket and assigned id for tracking purposes.
        public Socket _socket { get; set; }
        public int Id { get; set; }

        public Client(Socket socket, int id)
        {
            _socket = socket;
            Id = id;
        }
    }
}
