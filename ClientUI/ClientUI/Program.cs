using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientSide;
using Shared;

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

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
