using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twokan.Client.Display;

namespace Twokan.Client
{
    class Program
    {
        #region Fields

        static MainMenu screenMainMenu;

        #endregion

        #region Properties

        public static MainMenu ScreenMainMenu
        {
            get
            {
                return screenMainMenu;
            }

            set
            {
                screenMainMenu = value;
            }
        }
  
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Twokan : client");
            ScreenMainMenu = new MainMenu();

            Console.ReadLine();
        }
    }
}
