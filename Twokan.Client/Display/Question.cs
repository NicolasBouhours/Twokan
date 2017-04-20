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
            Console.WriteLine("Bienvenu dans la partie numéro {0} (q pour retourner au menu)", code);
            Console.WriteLine("Appuyer sur une touche pour continuer");
            saisie = Console.ReadLine();

            ////Check if the player want quit and quit him 
            if (this.CheckIfHeWantLeave(saisie))
            {
                this.QuitGame();
            }

            ////[TODO] Get the questions on the server

            ////throw new NotImplementedException(No question on the server");
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
                Console.WriteLine("Etes-vous sûr de vouloir quitter ? (Y/N)");
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
            //// [TODO] GO back in the main menu

            ////[TODO]

            ////MainMenu main = new MainMenu();

            ////throw new NotImplementedException("Main menu not create");
        }
    }
}
