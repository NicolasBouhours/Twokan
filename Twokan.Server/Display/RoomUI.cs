﻿namespace Twokan.Server.Display
{
    using System;
    using System.Threading;
    using Twokan.Server.Model;

    public static class RoomUI
    {
        /// <summary>
        /// Enable to start a game by displaying all questions
        /// </summary>
        /// <param name="r">The room of the game</param>
        public static void Start(Room r)
        {
            if (r != null)
            {
                Console.Clear();
                Console.WriteLine("Twokan : Room " + r.Id.ToString());
                Console.WriteLine("----------------");

                // TODO : Display room info
                foreach (Question q in r.ListQuestions)
                {
                    QuestionUI.Start(q);
                    Thread.Sleep(15000);
                }

                ScoreUI.Start(r);
            }
        }
    }
}
