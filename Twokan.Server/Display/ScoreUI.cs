using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twokan.Server.Model;

namespace Twokan.Server.Display
{
    public class ScoreUI
    {
        public static void StartScoreUI(Room room)
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
