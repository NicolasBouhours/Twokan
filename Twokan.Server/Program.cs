namespace Twokan.Server
{
    using Display;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class Program
    {
        public static void Main(string[] args)
        {
            bool isRunning = true;
            Console.WriteLine("Twokan : serveur");

            TwokanServer server = new TwokanServer("127.0.0.1", 2000);

            MainUI.Start();

            server.Close();        
        }
    }
}
