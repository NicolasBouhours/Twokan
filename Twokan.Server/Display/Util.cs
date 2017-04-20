using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twokan.Server.Display;

namespace Twokan.Server.Display
{
    public class Util
    {
        public static void QuitUI()
        {
            String code = "";
            do
            {
                Console.WriteLine("X pour quitter");
                code = Console.ReadLine().Trim();
            } while (code != "x");

            MainUI.StartMainUI();
        }
    }
}
