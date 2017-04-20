using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twokan.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            Console.WriteLine("Twokan : serveur");

            TwokanServer server = new TwokanServer("127.0.0.1", 2000);

            // Behaviour server here
            while(isRunning)
            {
                server.Send(null, "test");
            }
            
        }
    }
}
