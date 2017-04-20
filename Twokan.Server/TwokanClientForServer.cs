using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twokan.Core;

namespace Twokan.Server
{
    /// <summary>
    /// Class to communicate with tcpclients found by server
    /// </summary>
    public class TwokanClientForServer : TwokanCoreClient
    {
        /// <summary>
        /// Init the tcpclient get by the server
        /// </summary>
        /// <param name="newClient">The tcpclient found</param>
        /// <param name="newClientUserName">The username of the client</param>
        public TwokanClientForServer(TcpClient newClient, string newClientUserName)
        {
            client = newClient;
            userName = newClientUserName;

            isRunning = true;
            stream = client.GetStream();

            listenerThread = new Thread(Listen);
            listenerThread.Start();
        }
    }
}
