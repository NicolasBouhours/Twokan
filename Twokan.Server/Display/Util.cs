namespace Twokan.Server.Display
{
    using System;

    public static class Util
    {
        /// <summary>
        /// Enable to quit the game
        /// </summary>
        public static void QuitUI()
        {
            string code = string.Empty;
            do
            {
                Console.WriteLine("X pour quitter");
                code = Console.ReadLine().Trim();
            }
            while (code != "x");

            MainUI.Start();
        }
    }
}
