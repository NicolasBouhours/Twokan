namespace Twokan.Server.Display
{
    using System;
    using Twokan.Server.Model;

    public static class QuestionUI
    {
        /// <summary>
        /// Display question program
        /// </summary>
        /// <param name="q"></param>
        public static void Start(Question q)
        {
            if (q != null)
            {
                // Displaying question page
                Console.Clear();
                Console.WriteLine("Twokan : Question " + q.Title);
                Console.WriteLine("----------------");
                Console.WriteLine(q.Content);
                Console.WriteLine("----------------");

                int i = 1;

                // For each choice for the question, show choice
                foreach (string s in q.Choices)
                {
                    Console.WriteLine(i.ToString() + " - " + s);
                    i++;
                }

                Util.QuitUI();
            }
        }
    }
}
