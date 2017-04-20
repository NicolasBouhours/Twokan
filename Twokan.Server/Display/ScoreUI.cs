namespace Twokan.Server.Display
{
    using System;
    using System.Collections.Generic;
    using Twokan.Server.Model;

    public static class ScoreUI
    {
        public static void Start(Room room)
        {
            if (room != null)
            {
                Console.Clear();
                Console.WriteLine("Twokan : Scores");
                Console.WriteLine("----------------");

                //TODO : Display scores

                if (room != null)
                {
                    if (room.ListGamers != null && room.ListGamers.Count > 0)
                    {
                        foreach (Gamer gamer in room.ListGamers)
                        {
                            Console.WriteLine("Gamer " + gamer.Name + " : " + gamer.Score.ToString() + " point(s)");
                        }

                        Console.WriteLine("----------------");
                    }
                }

                Util.QuitUI();
            }
        }
    }
}
