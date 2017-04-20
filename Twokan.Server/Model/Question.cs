using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twokan.Server.Model
{
    class Question
    {
        private string title;
        private string content;
        private List<string> questions;
        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        public List<string> Questions
        {
            get { return questions; }
            set { questions = value; }
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
