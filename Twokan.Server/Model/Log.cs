namespace Twokan.Server.Model
{
    using System;

    public class Log
    {
        private string action;
        private DateTime date;
        private Gamer gamer;

        public Gamer Gamer
        {
            get { return gamer; }
            set { gamer = value; }
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

        public Log(string action, DateTime date, Gamer gamer)
        {
            this.action = action;
            this.date = date;
            this.gamer = gamer;
        }
    }
}
