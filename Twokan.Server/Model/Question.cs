namespace Twokan.Server.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Question
    {
        private string title;
        private string content;
        private ICollection<string> choices;
        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        public ICollection<string> Choices
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
