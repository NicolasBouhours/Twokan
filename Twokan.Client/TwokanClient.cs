namespace Twokan.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Twokan.Core;

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
        public TwokanClient(string server, int port, string username)
        {
            client = new TcpClient("127.0.0.1", 2000); // Open the connection with the server
            this.userName = username;

            isRunning = true;
            stream = client.GetStream();

            //Wait connexion validation
            bool connected = this.SetupConnection();

            if (connected)
            {
                listenerThread = new Thread(Listen);
                listenerThread.Start();
            }
        }

        private bool SetupConnection()
        {
            // Buffer to store the response bytes.
            byte[] data = new byte[TwokanParams.messageLength];

            // String to store the response ASCII representation.
            string responseData = string.Empty;

            // Read the first batch of the TcpServer response bytes.
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

            TwokanMessage message = new TwokanMessage();
            message.DeserializeMessage(responseData);

            if (message != null && message.Message == TwokanParams.messageAskInformationUser)
            {
                this.Send(new TwokanMessage() { UserName = this.userName, Message = TwokanParams.messageSendInfoUser });

                // String to store the response ASCII representation.
                responseData = string.Empty;

                // Read the first batch of the TcpServer response bytes.
                bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                TwokanMessage messageOk = new TwokanMessage();
                messageOk.DeserializeMessage(responseData);

                if (messageOk != null && messageOk.Message == TwokanParams.messageConnectionOk)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Impossible de se connecter au serveur : {messageOk?.Message ?? string.Empty }");
                    this.Close();
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"Impossible de se connecter au serveur : {message?.Message ?? string.Empty }");
                this.Close();
                return false;
            }
        }
    }
}
