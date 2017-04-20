namespace Twokan.Server.Model
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("Gendarme.Rules.Naming", "AvoidLackOfCohesionOfMethodsRule")]
    public class Log
    {
        private string action;

        private DateTime date;

        private Gamer client;

        public Gamer Client
        {
            get { return client; }
            set { client = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Action
        {
            get { return action; }
            set { action = value; }
        }
    }
}
