namespace Twokan.Server.Display
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Twokan.Server.Model;

    public static class LogUI
    {
        public static void Start(ICollection<Log> clientsLogs)
        {
            if (clientsLogs != null)
            {
                Console.Clear();
                Console.WriteLine("Twokan : Logs");
                Console.WriteLine("----------------");

                // TODO : Display logs
                foreach (Log l in clientsLogs)
                {
                    Console.WriteLine(l.Date.ToString() + " : " + l.Client.Name + " " + l.Action);
                }

                Util.QuitUI();
            }
        }
    }
}
