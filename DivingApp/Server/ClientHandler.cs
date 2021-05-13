using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerSide
{
    public class ClientHandler
    {
        static List<Client> Clients = new List<Client>();

        public void AddClient(Socket socket)
        {
            Clients.Add(new Client(socket, Clients.Count));
            //Start receiving/responding
        }

        public void RemoveClient(int id)
        {
            Clients.RemoveAt(Clients.FindIndex(x => x.Id == id));
        }

        private void receiveMessage(Client client)
        {
            //TODO: Implement method that receives a message from the client and sends it to the message dispatcher
        }
    }
}
