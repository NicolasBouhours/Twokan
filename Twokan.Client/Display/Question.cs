using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twokan.Client.Display
{
    public class Question
    {
        string saisie;

        /// <summary>
        /// [TODO] Ecran des questions 
        /// </summary>
        /// <param name="code">numéro de la partie</param>
        public Question(string code)
        {
            Console.Clear();
            Console.WriteLine("Bienvenu dans la partie numéro "+code+" (q pour retourner au menu)" );
            Console.WriteLine("Aucune questions sur le serveur pour le moment !");
            saisie = Console.ReadLine();

            //Regarde si le joueur souhaite quitter la partie et le fait quitter
            if(checkIfHeWantLeave(saisie))
            {
                quitGame();
            }
            else //[TODO] A supprimer quand il y aura les questions de disponible
            {
                quitGame();
            }

            //[TODO] Recupére les questions du jeux sur le serveur et commence le Jeux
            

        }


        /// <summary>
        /// Renvoi un boolean pour savoir si le joueur veux vraiment quiiter
        /// </summary>
        /// <param name="saisie">Saisie de l'utilisateur</param>
        /// <returns></returns>
        public Boolean checkIfHeWantLeave(string saisie)
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
        /// [TODO] Retourne au Main Menu
        /// </summary>
        public void quitGame()
        {
            //[TODO]
            //MainMenu main = new MainMenu();
 
        }
    }
}
