namespace Twokan.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Display;

    public static class Program
    {
        #region Fields

        static MainMenu screenMainMenu;
        
        #endregion

        private static void Main()
        {
            Console.WriteLine("Twokan : client");
            ScreenMainMenu = new MainMenu();

            Console.ReadLine();
        }

        #region Properties
        
        internal static MainMenu ScreenMainMenu
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
    }
}