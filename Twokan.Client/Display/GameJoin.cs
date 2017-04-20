namespace Twokan.Client.Display
{
    using System;

    public class GameJoin
    {
        /// <summary>
        /// Demande et vérifie le code de la partie à rejoindre
        /// </summary>
        public GameJoin()
        {
            string code = string.Empty;

            ////Demande le code de la partie à rejoindre
            Console.Clear();
            Console.WriteLine("Code de la partie ?");
            code = Console.ReadLine();

            ////Regarde si le code existe et si il est au bon format
            while (!this.CheckIfCodeExist(code))
            {
                Console.Clear();
                Console.WriteLine("Ce code n'est pas valide veuillez en ressaisir un ou 'q' pour quitter");
                code = Console.ReadLine();

                ////Renvoyer à l'ecran précédent nommé MainMenu
                if (code == "q")
                {
                    ////TODO]

                    ////MainMenu main = new MainMenu();
                    ////throw new NotImplementedException("Main menu not create");
                }
            }

            ////On redirige vers l'ecran quaestion
            Question q  = new Question(code);
        }

        /// <summary>
        /// Regarde si le code est au bon format et demande au serveur si la partie existe
        /// </summary>
        /// <param name="code">Code saisie par l'utilisateur</param>
        /// <returns>Result</returns>
        public bool CheckIfCodeExist(string code)
        {
            int codeNum;

            ////Verifie le format du code
            if (int.TryParse(code, out codeNum))
            {
                ////TODO] Verifie si le code existe sur le serveur

                ////throw new NotImplementedException("Verifier le code de la partie sur le serveur");
            }

            return false;
        }
    }
}
