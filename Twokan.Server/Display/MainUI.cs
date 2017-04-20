using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Question q = new Question();
            q.Title = "Question 1";
            q.Content = "Quel est la couleur du cheval blanc d'henry 4 ?";
            List<string> choices = new List<string>();
            choices.Add("Noir");
            choices.Add("Vert");
            choices.Add("Blanc");
            choices.Add("Rose");
            q.Result = "Blanc";
            q.Choices = choices;

            Room r = new Room();
            r.Id = 0;
            r.ListQuestions = new List<Question>();
            r.ListQuestions.Add(q);
            Question q2 = q;
            q2.Title = "Question 2";
            r.ListQuestions.Add(q2);
            r.ListQuestions.Add(q);


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
                        this.StartRoomUI(r);
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

        public void StartScoreUI(Room r)
        {
            Console.Clear();
            Console.WriteLine("Twokan : Scores");
            Console.WriteLine("----------------");

            // TODO : Display scores

            this.QuitUI();
        }

        public void StartRoomUI(Room r)
        {
            Console.Clear();
            Console.WriteLine("Twokan : " + r.Id);
            Console.WriteLine("----------------");

            // TODO : Display room info

            foreach(Question q in r.ListQuestions) {
                StartQuestionUI(q);
                Thread.Sleep(15000);
            }

            this.StartScoreUI(r);
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
