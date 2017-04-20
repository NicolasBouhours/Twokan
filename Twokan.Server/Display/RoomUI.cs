namespace Twokan.Server.Display
{
    using System;
    using System.Threading;
    using Twokan.Server.Model;

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
