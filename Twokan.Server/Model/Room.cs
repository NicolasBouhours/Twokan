namespace Twokan.Server.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Room
    {
        private int id;

        private ICollection<Question> listQuestions;

        private ICollection<Gamer> listGamers;

        public ICollection<Gamer> ListGamers
        {
            get { return listGamers; }
            set { listGamers = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public ICollection<Question> ListQuestions
        {
            get { return listQuestions; }
            set { listQuestions = value; }
        }
    }
}
