namespace Twokan.Server.Display
{
    using System;
    using System.Collections.Generic;
    using Twokan.Server.Model;

    public static class MainUI
    {
        /// <summary>
        /// Main entry of the program. Show menu for switching to score, log and room
        /// </summary>
        public static void Start()
        {
            // Displaying the menu
            Console.Clear();
            Console.WriteLine("Twokan : serveur");
            Console.WriteLine("----------------");
            Console.WriteLine("1 - Score");
            Console.WriteLine("2 - Log");
            Console.WriteLine("3 - Start Game");

            // Mock data
            string choice;
            Room room = new Room();
            room.Id = 1;
            List<Gamer> gamers = new List<Gamer> { new Gamer(1, "Nico", 5), new Gamer(2, "Flo", 10) };
            room.ListGamers.Add(new Gamer(1, "Nico", 5));
            room.ListGamers.Add(new Gamer(2, "Flo", 10));
            List<Log> logs = new List<Log>();

            // Menu switch
            do
            {
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ScoreUI.Start(room);
                        break;
                    case "2":
                        LogUI.Start(logs);
                        break;
                    case "3":
                        RoomUI.Start(room);
                        break;
                }
            }
            while (choice != "1" || choice != "2" || choice != "3");
        }
    }
}
