using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twokan.Server.Model
{
    public class Question
    {
        private string title;
        private string content;
        private List<string> choices;
        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        public List<string> Choices
        {
            get { return choices; }
            set { choices = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

    }
}
