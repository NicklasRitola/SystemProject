using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shared;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ClientUI;

namespace TestClient
{
    class Program
    {
        static private ClientMessageDispatcher messageDispatcher = new ClientMessageDispatcher();
        static ClientChannel channel = new ClientChannel(messageDispatcher);

        static async Task Main(string[] args)
        {
            Console.WriteLine("Press Enter to connect to server");
            Console.ReadLine();

            await ConnectToServer();

            TestRequest request = new TestRequest();
            await channel.SendAsync(request);

            Console.ReadLine();
        }
        static async Task ConnectToServer()
        {
            try
            {
                var endpoint = new IPEndPoint(IPAddress.Loopback, 11111);
                await channel.ConnectAsync(endpoint).ConfigureAwait(false);
                Console.WriteLine("Client Running");
            }
            catch (Exception _e)
            {
                Console.WriteLine($"Client Exception: {_e}");
            }
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Press enter to connect");
        //    Console.ReadLine();

        //    JsonMessageProtocol jsonMessageProtocol = new JsonMessageProtocol();
        //    socket = connectToServer();

        //    //CreateCompetitionRequest request = new CreateCompetitionRequest();
        //    TestRequest request = new TestRequest();
        //    //Message request = new TestMessage();
        //    //Message response = new Response();

        //    while (true)
        //    {
        //        Console.WriteLine("Input any character to send a message, or press enter to exit program:");
        //        string choice = Console.ReadLine();
        //        if (choice != "")
        //        {
        //            transaction(request, jsonMessageProtocol);
        //            //transaction(response, jsonMessageProtocol);
        //        }
        //        else
        //            break;
        //    }
        //}

        //static void close(Socket socket)
        //{
        //    socket.Shutdown(SocketShutdown.Both);
        //    socket.Close();
        //}

        //static void transaction(Message message, JsonMessageProtocol messageCoder)
        //{
        //    //SENDING
        //    byte[] messageSent = messageCoder.Encode(message);
        //    int byteSent = socket.Send(messageSent);

        //    //TODO: Implement a receiver
        //    byte[] messageReceived = new byte[1024];
        //    string data = null;
        //    int byteRecv = 0;
        //    byteRecv = socket.Receive(messageReceived, messageReceived.Length, 0);
        //    data += Encoding.ASCII.GetString(messageReceived, 0, byteRecv);
        //    string JSONString = Encoding.ASCII.GetString(Convert.FromBase64String(data));
        //    Response decodedResponse = JsonConvert.DeserializeObject<Response>(JSONString);
        //    Console.WriteLine("Received a: " + decodedResponse.messageType);
        //}
        //static Socket connectToServer()
        //{
        //    //Socket socket = null;
        //    try
        //    {
        //        ipHost = Dns.GetHostEntry(Dns.GetHostName());
        //        ipAddr = ipHost.AddressList[0];
        //        localEndPoint = new IPEndPoint(ipAddr, 11111);
        //        socket = new Socket(ipAddr.AddressFamily,
        //                SocketType.Stream, ProtocolType.Tcp);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //    }
        //    try
        //    {
        //        socket.Connect(localEndPoint);

        //        Console.WriteLine("Socket connected to -> {0}",
        //            socket.RemoteEndPoint.ToString());
        //    }

        //    catch (ArgumentNullException ane)
        //    {

        //        Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
        //    }

        //    catch (SocketException se)
        //    {

        //        Console.WriteLine("SocketException : {0}", se.ToString());
        //    }

        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Unexpected exception : {0}", e.ToString());
        //    }

        //    return socket;
        //}
    }
}
