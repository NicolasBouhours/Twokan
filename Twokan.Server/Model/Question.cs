namespace Twokan.Server.Model
{
    using System;
    using System.Collections.Generic;

    public class Question
    {
        private string title;

        private string content;

        private ICollection<string> choices;

        private string correct;

        public string Correct
        {
            get { return correct; }
            set { correct = value; }
        }

        public ICollection<string> Choices
        {
            get { return choices; }
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

        public Question()
        {
            this.choices = new List<String>();
        }

    }
}
