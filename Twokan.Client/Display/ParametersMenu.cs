namespace Twokan.Client.Display
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    sealed class ParametersMenu
    {
        #region Fields

        private int timing;
        private int winPoint;

        #endregion

        public ParametersMenu()
        {
            Console.WriteLine("Menu: Parameters");
            
            this.Timing = Ask("Timing (seconds)");
            this.WinPoint = Ask("Win point");

            Console.WriteLine("---------Game is ready---------");
            Console.WriteLine("Timing = " + this.Timing.ToString() + " second(s)");
            Console.WriteLine("WinPoint = " + this.WinPoint.ToString());
            Console.WriteLine("Start Game ? (yes/no)");

            string input = String.Empty;
            do
            {
                input = Console.ReadLine();
            }
            while (input != "yes" && input != "no");

            if(input == "yes")
            {
                // TODO
                // Start game !
                throw new NotImplementedException();
            }
            else
            {
                Program.ScreenMainMenu.Show();
            }
        }

        #region Properties
        public int Timing
        {
            get
            {
                return this.timing;
            }

            set
            {
                this.timing = value;
            }
        }

        public int WinPoint
        {
            get
            {
                return this.winPoint;
            }

            set
            {
                this.winPoint = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Ask user to enter int parameter
        /// </summary>
        /// <param name="subject">Message to show</param>
        /// <returns></returns>
        private int Ask(string subject)
        {
            bool error = true;
            int intInput;
            do
            {
                Console.WriteLine(subject+":");
                string input = Console.ReadLine();
                
                if(int.TryParse(input, out intInput))
                {
                    error = false;
                }
                else
                {
                    Console.WriteLine("Error: Please enter a number, not a string !");
                }
            }
            while (error);

            return intInput;
        }

        #endregion

        
    }
}
