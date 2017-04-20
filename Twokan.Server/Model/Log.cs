namespace Twokan.Server.Model
{
    using System;

    public class Log
    {
        // Test action
        private string action;

        // Test date
        private DateTime date;

        // Hey ti's our gamer !
        private Gamer clientGamer;

        public Gamer ClientGamer
        {
            get { return clientGamer; }
            set { clientGamer = value; }
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
