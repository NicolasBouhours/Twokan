using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            do
            {
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        this.StartScoreUI();
                        break;
                    case "2":
                        this.StartLogUI();
                        break;
                    case "3":
                        this.StartQuestionUI();
                        break;
                }
            } while (choice != "1" || choice != "2" || choice != "3");
        }

        public void StartLogUI()
        {
            Console.Clear();
            Console.WriteLine("Twokan : Logs");
            Console.WriteLine("----------------");

            // TODO : Display logs

            this.QuitUI();
        }

        public void StartScoreUI()
        {
            Console.Clear();
            Console.WriteLine("Twokan : Scores");
            Console.WriteLine("----------------");

            // TODO : Display scores

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

        public void StartQuestionUI()
        {
            Console.Clear();
            Console.WriteLine("Twokan : Questions");
            Console.WriteLine("----------------");

            // TODO : Display scores

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
