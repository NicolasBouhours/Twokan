namespace Twokan.Server.Display
{
    using System;

    public class Util
    {
        public static void QuitUI()
        {
            String code = "";
            do
            {
                Console.WriteLine("X pour quitter");
                code = Console.ReadLine().Trim();
            } while (code != "x");

            MainUI.Start();
        }
    }
}
