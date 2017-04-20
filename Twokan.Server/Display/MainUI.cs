﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twokan.Server.Model;


namespace Twokan.Server.Display
{
    class MainUI
    {

        public void StartMainUI() {
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
                        this.StartScoreUI(room);
                        break;
                    case "2":
                        this.StartLogUI(logs);
                        break;
                    case "3":
                        this.StartRoomUI();
                        break;
                }
            } while (choice != "1" || choice != "2" || choice != "3");
        }

        public void StartLogUI(List<Log> logs)
        {
            Console.Clear();
            Console.WriteLine("Twokan : Logs");
            Console.WriteLine("----------------");

            // TODO : Display logs
            foreach(Log l in logs) {
                Console.WriteLine(l.Date.ToString() + " : " + l.Gamer.Name + " " + l.Action);
            }

            this.QuitUI();
        }

        public void StartScoreUI(Room room)
        {
            Console.Clear();
            Console.WriteLine("Twokan : Scores");
            Console.WriteLine("----------------");

            // TODO : Display scores

           if(room != null)
            {
                List<Gamer> gamers = room.ListGamers;
                if(gamers != null && gamers.Count > 0)
                {
                    foreach (Gamer gamer in gamers)
                    {
                        Console.WriteLine(String.Format("Gamer {0} : {1} point(s)", gamer.Name, gamer.Score));
                    }
                    Console.WriteLine("----------------");
                }
            }



            this.QuitUI();
        }

        public void StartRoomUI()
        {
            Console.Clear();
            Console.WriteLine("Twokan : Room ID");
            Console.WriteLine("----------------");

            // TODO : Display room info

            this.QuitUI();
        }

        public void StartQuestionUI(Question q)
        {
            Console.Clear();
            Console.WriteLine("Twokan : Question " + q.Title);
            Console.WriteLine("----------------");
            Console.WriteLine(q.Content);
            Console.WriteLine("----------------");

            int i = 1;

            foreach (string s in q.Choices)
            {
                Console.WriteLine(i + " - " + s);
                    i++;
            }

            this.QuitUI();
        }

        private void QuitUI()
        {
            String code = "";
            do
            {
                Console.WriteLine("X pour quitter");
                code = Console.ReadLine().Trim();
            } while (code != "x");

            this.StartMainUI();
        }
    }
}
