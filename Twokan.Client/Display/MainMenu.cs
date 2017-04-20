namespace Twokan.Client.Display
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    sealed class MainMenu
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
                    // TODO
                    // Show create room screen
                    // GameCreate ScreenGameCreate = new GameCreate();
                    throw new NotImplementedException();
                    break;
                case "2":
                    // TODO
                    // Show join room screen
                    // GameJoin ScreenGameJoin = new GameJoin();
                    throw new NotImplementedException();
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
