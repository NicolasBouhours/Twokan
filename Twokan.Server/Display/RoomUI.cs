using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twokan.Server.Model;

namespace Twokan.Server.Display
{
    public class RoomUI
    {
        public static void StartRoomUI(Room r)
        {
            Console.Clear();
            Console.WriteLine("Twokan : Room" + r.Id);
            Console.WriteLine("----------------");

            // TODO : Display room info
            foreach (Question q in r.ListQuestions)
            {
                QuestionUI.StartQuestionUI(q);
                Thread.Sleep(15000);
            }

            ScoreUI.StartScoreUI(r);
        }
    }
}
