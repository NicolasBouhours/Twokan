namespace Twokan.Server
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Twokan.Core;

    public class TwokanServer
    {
        /// <summary>
        /// Server listener
        /// </summary>
        TcpListener server;

        /// <summary>
        /// List of tcp client
        /// </summary>
        List<TwokanClientForServer> clients;

        /// <summary>
        /// Thread iwhere the loop to accept connection runs
        /// </summary>
        Thread serverThread;

        /// <summary>
        /// Do we wantto continue to run the server ?
        /// </summary>
        bool running;

        /// <summary>
        /// Initialize server
        /// </summary>
        /// <param name="ip">Ip of the server</param>
        /// <param name="port">Port of the server</param>
        public TwokanServer(string ip, int port)
        {
            this.server = new TcpListener(IPAddress.Parse(ip), port); // init server connection
            this.server.Start();
            this.running = true;
            this.clients = new List<TwokanClientForServer>();

            this.serverThread = new Thread(WaitConnection);
            this.serverThread.Start();
        }

        /// <summary>
        /// Send message throught the tcp stream
        /// </summary>
        /// <param name="username">Destination user</param>
        /// <param name="message">Message content</param>
        public void Send(string username, string message)
        {
            List<TwokanClientForServer> clientsToNotify = new List<TwokanClientForServer>();

            if (string.IsNullOrEmpty(username)) // No username -> we broadcast the message to all clients
            {
                clientsToNotify.AddRange(clients);
            }
            else
            {
                TwokanClientForServer clientToNotify = clients.FirstOrDefault(c => c.UserName.Equals(username));
                if (clientToNotify != null)
                {
                    clientsToNotify.AddRange(clientsToNotify);
                }
            }

            foreach (var client in clientsToNotify)
            {
                client.Send(new TwokanMessage() { UserName = "Server", Message = message });
            }
        }

        /// <summary>
        /// Thread : loop to detect and affect connections
        /// </summary>
        private void WaitConnection()
        {
            while (running)
            {
                Console.WriteLine("Waiting for connection");

                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine($"Client found ... ");

                NetworkStream stream = client.GetStream();
                string username = this.SetupConnection(client, stream);

                if (!string.IsNullOrEmpty(username))
                {
                    TwokanClientForServer twokanClient = new TwokanClientForServer(client, username, stream);
                    clients.Add(twokanClient);
                    Console.WriteLine($"Client connected ... UserName : {username}");
                }
                else
                {
                    stream.Close();
                    client.Close();
                }


            }
        }

        /// <summary>
        /// Close the tcp connection
        /// </summary>
        public void Close()
        {
            running = false;
            foreach (var client in clients)
            {
                client.Close();
            }
        }

        /// <summary>
        /// Setup the connection for a client
        /// When we get connection, we send a message to know the username of the client
        /// </summary>
        /// <param name="client">The tcp client found by the server</param>
        /// <returns>Return null string if there was an error or the username if all is ok</returns>
        private string SetupConnection(TcpClient client, NetworkStream stream)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes($"Server;{TwokanParams.messageAskInformationUser}");
            Byte[] finalDatas = new byte[TwokanParams.messageLength];

            Array.Copy(data, finalDatas, data.Length);

            stream.Write(finalDatas, 0, finalDatas.Length);
            stream.Flush();

            // Buffer to store the response bytes.
            byte[] getData = new byte[TwokanParams.messageLength];

            // String to store the response ASCII representation.
            string responseData = string.Empty;

            // Read the first batch of the TcpServer response bytes.
            Int32 bytes = stream.Read(getData, 0, getData.Length);
            responseData = System.Text.Encoding.ASCII.GetString(getData, 0, bytes);

            TwokanMessage message = new TwokanMessage();
            message.DeserializeMessage(responseData);

            if (message != null)
            {
                if (message.Message == TwokanParams.messageSendInfoUser)
                {
                    string userNameConnected = message.UserName;
                    TwokanClientForServer clientWithSameName = this.clients.FirstOrDefault(c => c.UserName == userNameConnected);
                    if (clientWithSameName != null)
                    {
                        //We already have user with this name
                        // so we send error with username
                        Console.WriteLine($"Username '{userNameConnected}' already used, connection aborted");
                        Byte[] dataMessage = System.Text.Encoding.ASCII.GetBytes($"Server;{TwokanParams.messageUsernameAlreadyUsed}");
                        Byte[] finalDataMessage = new byte[TwokanParams.messageLength];

                        Array.Copy(dataMessage, finalDataMessage, dataMessage.Length);
                        stream.Write(finalDataMessage, 0, finalDataMessage.Length);
                        stream.Flush();

                        return null;
                    }
                    else
                    {
                        Byte[] dataMessage = System.Text.Encoding.ASCII.GetBytes($"Server;{TwokanParams.messageConnectionOk}");
                        Byte[] finalDataMessage = new byte[TwokanParams.messageLength];

                        Array.Copy(dataMessage, finalDataMessage, dataMessage.Length);
                        stream.Write(finalDataMessage, 0, finalDataMessage.Length);
                        stream.Flush();

                        return userNameConnected;
                    }
                }
                else
                {
                    Console.WriteLine($"Bad message received (not TwokanParams.messageSendInfoUser) ");
                    return null;
                }
            } // end if (message != null)
            else
            {
                Console.WriteLine($"Impossible to deserialize");
                return null;
            }
        }
    }
}
