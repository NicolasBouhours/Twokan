using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Twokan.Client
{
    class Program
    {       

        static void Main(string[] args)
        {
            bool isRunning = true;
            Console.WriteLine("Twokan : client");

            TwokanClient client = new TwokanClient("127.0.0.1", 2000);

            while(isRunning)
            {
                // All the behavior code comes here
            }

            client.Close();
                           
            Console.ReadLine();
        }

        
    }
}
