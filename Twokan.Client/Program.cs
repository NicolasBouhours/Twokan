namespace Twokan.Client
{
    using Display;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            bool isRunning = true;
            Console.WriteLine("Twokan : client");

            TwokanClient client = new TwokanClient("127.0.0.1", 2000, "Suliac");

            MainMenu mainMenu = new MainMenu();

            client.Close();

            Console.WriteLine("client closed");
            Console.ReadLine();
        }
    }
}
