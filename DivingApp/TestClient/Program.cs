using ClientSide;
using Shared;
using System;
using System.Net.Sockets;
using System.Text;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to connect");
            Console.ReadLine();

            JsonMessageProtocol jsonMessageProtocol = new JsonMessageProtocol();
            ClientChannel socketHandler = new ClientChannel();


            //CreateCompetitionRequest request = new CreateCompetitionRequest();
            JudgePointRequest request = new JudgePointRequest();
            //Message request = new TestMessage();
            Message response = new Response();

            while (true)
            {
                Console.WriteLine("Input any character to send a message, or press enter to exit program:");
                string choice = Console.ReadLine();
                if (choice != "")
                {
                    transaction(request, jsonMessageProtocol, socketHandler);
                    transaction(response, jsonMessageProtocol, socketHandler);
                }
                else
                    break;
            }
        }

        static void close(Socket socket)
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        static void transaction(Message message, JsonMessageProtocol messageCoder, ClientChannel socketHandler)
        {
            Socket socket = socketHandler.connectToServer();

            //SENDING
            byte[] messageSent = messageCoder.Encode(message);
            int byteSent = socket.Send(messageSent);

            //TODO: Implement a receiver
            byte[] messageReceived = new byte[1024];
            string data = null;
            int byteRecv = 0;
            byteRecv = socket.Receive(messageReceived, messageReceived.Length, 0);
            data += Encoding.ASCII.GetString(messageReceived, 0, byteRecv);

            //Message messageBack = messageCoder.Decode(data);


            //Console.WriteLine("Response from server:\n" +
            //    "{0}\n" +
            //    "{1}", messageBack.type, messageBack.intVar);
        }
    }
}
