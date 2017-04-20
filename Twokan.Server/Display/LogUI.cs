﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twokan.Server.Model;

namespace Twokan.Server.Display
{
    public class LogUI
    {
        public static void StartLogUI(List<Log> logs)
        {
            Console.Clear();
            Console.WriteLine("Twokan : Logs");
            Console.WriteLine("----------------");

            // TODO : Display logs
            foreach (Log l in logs)
            {
                Console.WriteLine(l.Date.ToString() + " : " + l.Gamer.Name + " " + l.Action);
            }

            Util.QuitUI();
        }
    }
}
