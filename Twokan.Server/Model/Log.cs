namespace Twokan.Server.Model
{
    using System;

    public class Log
    {
        private string action;

        private DateTime date;

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
