using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

using System.Net;
using System.Net.Sockets;

namespace ClientUI
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        static MessageDispatcher messageDispatcher = new ClientMessageDispatcher();
        static ClientChannel channel = new ClientChannel(messageDispatcher);
        static IPEndPoint localEndPoint = null;

        [STAThread]
        static async Task Main()
        {
            await ConnectToServer();


            // ------ Forms ------
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(channel));


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
    }
}
