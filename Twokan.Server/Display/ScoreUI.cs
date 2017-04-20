namespace Twokan.Server.Display
{
    using System;
    using System.Collections.Generic;
    using Twokan.Server.Model;

    public class ScoreUI
    {
        public static void Start(Room room)
        {
            if (room != null)
            {
                Console.Clear();
                Console.WriteLine("Twokan : Scores");
                Console.WriteLine("----------------");

                // TODO : Display scores

                if (room != null)
                {
                    List<Gamer> gamers = room.ListGamers;
                    if (gamers != null && gamers.Count > 0)
                    {
                        foreach (Gamer gamer in gamers)
                        {
                            Console.WriteLine(String.Format("Gamer {0} : {1} point(s)", gamer.Name, gamer.Score));
                        }
                        Console.WriteLine("----------------");
                    }
                }

                Util.QuitUI();
            }
        }
    }
}
