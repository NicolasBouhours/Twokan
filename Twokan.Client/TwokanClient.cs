using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twokan.Core;

namespace Twokan.Client
{
        /// <summary>
    /// Client hosting de tcp connection
    /// </summary>
    public class TwokanClient : TwokanCoreClient
    {
        /// <summary>
        /// Init the connection to the server
        /// </summary>
        /// <param name="server">The Ip of the server</param>
        /// <param name="port">The port of the server</param>
        public TwokanClient(string server, int port)
        {
            client = new TcpClient("127.0.0.1", 2000); // Open the connection with the server

            isRunning = true;
            stream = client.GetStream();

            listenerThread = new Thread(Listen);
            listenerThread.Start();
        }
    }
}
