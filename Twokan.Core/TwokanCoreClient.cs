using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Twokan.Core
{
    public abstract class TwokanCoreClient
    {
        /// <summary>
        /// Username of the client
        /// </summary>
        protected string userName;

        /// <summary>
        /// TCP connection
        /// </summary>
        protected TcpClient client;

        /// <summary>
        /// Thread within the loop to listen message
        /// </summary>
        protected Thread listenerThread;

        /// <summary>
        /// Stream of the messages
        /// </summary>
        protected NetworkStream stream;

        /// <summary>
        /// Var to know if we need to continue to run the client (if not, stop the listening thread)
        /// </summary>
        protected bool isRunning;

        public string UserName
        {
            get { return userName; }
        }

        /// <summary>
        /// Send message to the client
        /// </summary>
        /// <param name="message">The message</param>
        public void Send(TwokanMessage message)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message.SerializeMessage());
            Byte[] finalDatas = new byte[TwokanParams.messageLength];

            Array.Copy(data, finalDatas, data.Length);

            stream.Write(finalDatas, 0, finalDatas.Length);
            stream.Flush();
        }

        /// <summary>
        /// Thread where we listen the incomming messages
        /// </summary>
        public void Listen()
        {
            while (isRunning)
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

                // TODO : Behaviour to interpret the messages here

                Console.WriteLine($"Received from {message.UserName} : {message.Message}");
            }
        }

        /// <summary>
        /// Close stream and clients
        /// </summary>
        public void Close()
        {
            isRunning = false;

            stream.Close();
            client.Close();
        }
    }
}
