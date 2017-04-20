namespace Twokan.Server.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("Gendarme.Rules.Maintainability", "AvoidLackOfCohesionOfMethodsRule")]
    public class Question
    {
        public string Title { get; set; }

        public string content { get; set; }

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
