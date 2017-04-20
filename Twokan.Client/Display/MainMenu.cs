namespace Twokan.Client.Display
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class MainMenu
    {
        public MainMenu()
        {
            this.Show();
        }

        #region Methods

        /// <summary>
        /// Show main menu and wait for user input
        /// </summary>
        public void Show()
        {
            Console.WriteLine("Menu: TWOKAN");
            Console.WriteLine("1 = Create room");
            Console.WriteLine("2 = Join room");
            Console.WriteLine("0 = Exit");

            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    ParametersMenu ScreenParametersMenu = new ParametersMenu();
                    break;
                case "2":
                    GameJoin ScreenGameJoin = new GameJoin();
                    break;
                default:
                    // nothing
                    this.Show();
                    break;
            }
        }

        #endregion
    }
}
