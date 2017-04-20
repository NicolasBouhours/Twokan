namespace Twokan.Server.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Log
    {
        private string action;
        private DateTime date;
        private Gamer gamer;

        public Gamer ClientGamer
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

    }
}
