namespace Twokan.Server.Display
{
    using System;
    using System.Collections.Generic;
    using Twokan.Server.Model;

    public static class ScoreUI
    {
        /// <summary>
        /// Enable To display the score of au gamers based on a room
        /// </summary>
        /// <param name="room">Room of the game</param>
        public static void Start(Room room)
        {
            if (room != null)
            {
                Console.Clear();
                Console.WriteLine("Twokan : Scores");
                Console.WriteLine("----------------");

                if (room != null)
                {
                    if (room.ListGamers != null && room.ListGamers.Count > 0)
                    {
                        // loop on all the gamers and display name and the score
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
