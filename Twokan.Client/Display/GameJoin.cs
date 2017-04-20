namespace Twokan.Client.Display
{
    using System;

    public class GameJoin
    {
        /// <summary>
        /// Ask and verify the code of the game
        /// </summary>
        public GameJoin()
        {
            string code = string.Empty;

            ////Ask the code of the game
            Console.Clear();
            Console.WriteLine("Party code ?");
            code = Console.ReadLine();

            ////Check the format of the code
            while (!this.CheckIfCodeExist(code))
            {
                Console.Clear();
                Console.WriteLine("Invalid code, please input a valid one or press 'q' to quit");
                code = Console.ReadLine();

                ////Go back in the Main menu
                if (code == "q")
                {
                    MainMenu main = new MainMenu();
                }
            }

            ////Go at the question display
            Question q  = new Question(code);
        }

        /// <summary>
        /// Check the format code and ask at the server if exist
        /// </summary>
        /// <param name="code">Output by the user</param>
        /// <returns>Result</returns>
        public bool CheckIfCodeExist(string code)
        {
            int codeNum;

            ////Check the format code
            if (int.TryParse(code, out codeNum))
            {
                ////TODO] Check if the code exist on the server

                ////throw new NotImplementedException("Verifier le code de la partie sur le serveur");
            }

            return false;
        }
    }
}
