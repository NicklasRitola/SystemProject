using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientSide;
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
            // ------ Test connection ------
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ip = ipHost.AddressList[0];
            localEndPoint = new IPEndPoint(ip, 11111);

            await channel.ConnectAsync(localEndPoint);
            CreateCompetitionRequest request = new CreateCompetitionRequest();
            request.Location = "test";
            await channel.SendAsync(request);

            // ------ Forms ------
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
