using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[assembly: CLSCompliant(true)]

namespace Twokan.Client.Display
{
    public class GameJoin
    {
        /// <summary>
        /// [TODO] Demande et vérifie le code de la partie à rejoindre
        /// </summary>
        public GameJoin()
        {
            string code = string.Empty;

            //Demande le code de la partie à rejoindre
            Console.Clear();
            Console.WriteLine("Code de la partie ?");
            code = Console.ReadLine();


            //Regarde si le code existe et si il est au bon format
            while(!CheckIfCodeExist(code))
            {
                Console.Clear();
                Console.WriteLine("Ce code n'est pas valide veuillez en ressaisir un ou 'q' pour quitter");
                code = Console.ReadLine();

                //Renvoyer à l'ecran précédent nommé MainMenu
                if(code == "q")
                {
                    //[TODO]
                    //MainMenu main = new MainMenu();
                }
            }

            //On redirige vers l'ecran quaestion
            Question q  = new Question(code);


        }

        /// <summary>
        /// [TODO] Regarde si le code est au bon format et demande au serveur si la partie existe
        /// </summary>
        /// <param name="code">Code saisie par l'utilisateur</param>
        /// <returns></returns>
        public bool CheckIfCodeExist(string code)
        {
            int codeNum;

            //Verifie le format du code
            if (int.TryParse(code, out codeNum))
            {
                //[TODO] Verifie si le code existe sur le serveur

                return true;
            }


            return false;
        }
    }
}
