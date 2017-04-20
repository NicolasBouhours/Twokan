using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twokan.Client.Display
{
    class ParametersMenu
    {
        #region Fields

        private int timing;
        private int winPoint;

        #endregion

        public ParametersMenu()
        {
            Console.WriteLine("Menu: Parameters");
            
            Timing = Ask("Timing (seconds)");
            WinPoint = Ask("Win point");

            Console.WriteLine("---------Game is ready---------");
            Console.WriteLine("Timing = " + Timing + " second(s)");
            Console.WriteLine("WinPoint = " + WinPoint);
            Console.WriteLine("Start Game ? (yes/no)");

            string input = String.Empty;
            do
            {
                input = Console.ReadLine();
            } while (input != "yes" && input != "no");

            if(input == "yes")
            {
                //TODO
                //Start game !
                throw new NotImplementedException();
            } else
            {
                Program.ScreenMainMenu.Show();
            }
        }

        #region Methods

        private int Ask(string subject)
        {
            bool error = true;
            int intInput = -1;
            do
            {
                Console.WriteLine(subject+":");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out intInput))
                {
                    error = false;
                }
                else
                {
                    Console.WriteLine("Error: Please enter a number, not a string !");
                }
            } while (error);

            return intInput;
        }

        #endregion

        #region Properties
        public int Timing
        {
            get
            {
                return timing;
            }

            set
            {
                timing = value;
            }
        }

        public int WinPoint
        {
            get
            {
                return winPoint;
            }

            set
            {
                winPoint = value;
            }
        }

        #endregion
    }
}
