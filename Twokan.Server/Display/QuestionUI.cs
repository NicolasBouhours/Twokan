namespace Twokan.Server.Display
{
    using System;
    using Twokan.Server.Model;

    public static class QuestionUI
    {
        public static void Start(Question q)
        {
            if (q != null)
            {
                Console.Clear();
                Console.WriteLine(String.Format("Twokan : Question {0}", q.Title));
                Console.WriteLine("----------------");
                Console.WriteLine(q.Content);
                Console.WriteLine("----------------");

                int i = 1;

                foreach (string s in q.Choices)
                {
                    Console.WriteLine(String.Format("{0} - {1}", i.ToString(), s));
                    i++;
                }

                Util.QuitUI();
            }
        }
    }
}
