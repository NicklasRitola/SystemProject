
using System;
using ServerSide;
using ClientSide;
using Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        ClientChannel client = new ClientChannel();

        Request request = new Request();

        [TestMethod]
        public void TestMethod1()
        {
            client.connectToServer();
            client.transaction(request);
            client.CloseConnection();
        }
    }
}
