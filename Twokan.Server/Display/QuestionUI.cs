using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twokan.Server.Model;

namespace Twokan.Server.Display
{
    public class QuestionUI
    {
        public static void StartQuestionUI(Question q)
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

            Util.QuitUI();
        }
    }
}
