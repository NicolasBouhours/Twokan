using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twokan.Server.Model;


namespace Twokan.Server.Display
{
    class MainUI
    {

        public static void StartMainUI() {
            Console.Clear();
            Console.WriteLine("Twokan : serveur");
            Console.WriteLine("----------------");
            Console.WriteLine("1 - Score");
            Console.WriteLine("2 - Log");
            Console.WriteLine("3 - Start Game");

            string choice = "";
            Room room = new Room();
            room.Id = 1;
            List<Gamer> gamers = new List<Gamer> { new Gamer(1, "Nico", 5),new Gamer(2,"Flo",10) };
            room.ListGamers = gamers;
            List<Log> logs = new List<Log>();


            do
            {
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ScoreUI.StartScoreUI(room);
                        break;
                    case "2":
                        LogUI.StartLogUI(logs);
                        break;
                    case "3":
                        RoomUI.StartRoomUI(room);
                        break;
                }
            } while (choice != "1" || choice != "2" || choice != "3");
        }
    }
}
