namespace Twokan.Client.Display
{
    using System;

    public class Question
    {
        /// <summary>
        /// Display about question 
        /// </summary>
        /// <param name="code">number of the game</param>
        public Question(string code)
        {
            string saisie = string.Empty;

            Console.Clear();
            Console.WriteLine("Welcolm in party number {0} (press q to go to menu)", code);
            Console.WriteLine("Press any key to continue");
            saisie = Console.ReadLine();

            ////Check if the player want quit and quit him 
            if (this.CheckIfHeWantLeave(saisie))
            {
                this.QuitGame();
            }

            ////[TODO] Get the questions on the server
            throw new NotImplementedException("No question on the server");
        }

        /// <summary>
        /// Check if the player want really quit
        /// </summary>
        /// <param name="saisie">Input of the user</param>
        /// <returns></returns>
        public bool CheckIfHeWantLeave(string saisie)
        {
            ////Go back in the menu
            if (saisie == "q")
            {
                Console.WriteLine("Are you sure to exit ? (Y/N)");
                saisie = Console.ReadLine();

                ////If he want really quit
                if (saisie == "Y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Go back in the Main Menu
        /// </summary>
        public void QuitGame()
        {
            MainMenu main = new MainMenu();
        }
    }
}
