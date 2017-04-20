namespace Twokan.Client.Display
{
    using System;

    public class Question
    {
        /// <summary>
        /// Ecran des questions 
        /// </summary>
        /// <param name="code">numéro de la partie</param>
        //[TODO] Recupèrer les question sur le serveur
        public Question(string code)
        {
            string saisie = string.Empty;

            Console.Clear();
            Console.WriteLine("Bienvenu dans la partie numéro "+code+" (q pour retourner au menu)" );
            Console.WriteLine("Appuyer sur une touche pour continuer");
            saisie = Console.ReadLine();

            //Regarde si le joueur souhaite quitter la partie et le fait quitter
            if(CheckIfHeWantLeave(saisie))
            {
                QuitGame();
            }


            //[TODO] Recupére les questions du jeux sur le serveur et commence le Jeux
            throw new NotImplementedException("Aucune question sur le serveur");
        }


        /// <summary>
        /// Renvoi un boolean pour savoir si le joueur veux vraiment quiiter
        /// </summary>
        /// <param name="saisie">Saisie de l'utilisateur</param>
        /// <returns></returns>
        public Boolean CheckIfHeWantLeave(string saisie)
        {
            //Permet de retourner au menu
            if (saisie == "q")
            {
                Console.WriteLine("Etes-vous sûr de vouloir quitter ? (Y/N)");
                saisie = Console.ReadLine();

                //Regarde si il souhaite vraiment quitter
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
        // [TODO] Retourner sur le main menu
        public void QuitGame()
        {
            //[TODO]
            //MainMenu main = new MainMenu();
            throw new NotImplementedException("Main menu not create");
        }
    }
}
