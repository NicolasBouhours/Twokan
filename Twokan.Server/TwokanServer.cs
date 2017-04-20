using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Twokan.Server
{
    public class TwokanServer
    {
        TcpListener server;
        List<TwokanClientForServer> clients;
        Thread serverThread;

        bool running;

        public TwokanServer(string ip, int port)
        {
            server = new TcpListener(IPAddress.Parse(ip), port); // init server connection
            server.Start();
            running = true;
            clients = new List<TwokanClientForServer>();

            serverThread = new Thread(WaitConnection);
            serverThread.Start();

        }

        public void Send(string username, string message)
        {
            List<TwokanClientForServer> clientsToNotify = new List<TwokanClientForServer>();

            if(string.IsNullOrEmpty(username)) // No username -> we broadcast the message to all clients
            {
                clientsToNotify.AddRange(clients);
            }
            else
            {
                TwokanClientForServer clientToNotify = clients.FirstOrDefault(c => c.UserName.Equals(username));
                if(clientToNotify != null)
                {
                    clientsToNotify.AddRange(clientsToNotify);
                }
            }

            foreach (var client in clientsToNotify)
            {
                client.Send(message);
            }
        }

        private void WaitConnection()
        {
            while (running)
            {
                Console.WriteLine("Waiting for connection");

                TcpClient client = server.AcceptTcpClient();

                //TODO : Get username
                // 1 : Send "connection is ok" message
                // 2 : Client should send username 

                TwokanClientForServer twokanClient = new TwokanClientForServer(client, "A faire");
                clients.Add(twokanClient);
                Console.WriteLine("Client connected ...");
            }
        } 

        public void Close()
        {
            running = false;
            foreach (var client in clients)
            {
                client.Close();
            }
        }
    }
}
