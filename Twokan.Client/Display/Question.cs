namespace Twokan.Client.Display
{
    using System;

    public class Question
    {
        /// <summary>
        /// Ecran des questions 
        /// </summary>
        /// <param name="code">numéro de la partie</param>
        public Question(string code)
        {
            string saisie = string.Empty;

            Console.Clear();
            Console.WriteLine("Bienvenu dans la partie numéro {0} (q pour retourner au menu)",code);
            Console.WriteLine("Appuyer sur une touche pour continuer");
            saisie = Console.ReadLine();

            ////Regarde si le joueur souhaite quitter la partie et le fait quitter
            if (this.CheckIfHeWantLeave(saisie))
            {
                this.QuitGame();
            }

            ////[TODO] Recupére les questions du jeux sur le serveur et commence le Jeux

            ////throw new NotImplementedException("Aucune question sur le serveur");
        }

        /// <summary>
        /// Renvoi un boolean pour savoir si le joueur veux vraiment quiiter
        /// </summary>
        /// <param name="saisie">Saisie de l'utilisateur</param>
        /// <returns></returns>
        public bool CheckIfHeWantLeave(string saisie)
        {
            ////Permet de retourner au menu
            if (saisie == "q")
            {
                Console.WriteLine("Etes-vous sûr de vouloir quitter ? (Y/N)");
                saisie = Console.ReadLine();

                ////Regarde si il souhaite vraiment quitter
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
        /// Retourne au Main Menu
        /// </summary>
        public void QuitGame()
        {
            //// [TODO] Retourner sur le main menu

            ////[TODO]

            ////MainMenu main = new MainMenu();

            ////throw new NotImplementedException("Main menu not create");
        }
    }
}
