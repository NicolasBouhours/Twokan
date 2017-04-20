namespace Twokan.Server.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    public class Question
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public ICollection<string> Choices { get;}

        public string Correct{ get; set; }

        /// <summary>
        ///     Contructeur
        /// </summary>
        public Question()
        {
            this.Choices = new List<String>();
        }

    }
}
