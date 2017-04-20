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

        public static MainMenu screenMainMenu;

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

        private static void Main()
        {
            Console.WriteLine("Twokan : client");
            ScreenMainMenu = new MainMenu();

            Console.ReadLine();
        }


    }
}