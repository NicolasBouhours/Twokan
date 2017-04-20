namespace Twokan.Server.Model
{
    using System.Collections.Generic;

    public class Room
    {
        private int id;

        private ICollection<Question> listQuestions;

        private ICollection<Gamer> listGamers;

        public ICollection<Gamer> ListGamers
        {
            get { return listGamers; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public ICollection<Question> ListQuestions
        {
            get { return listQuestions; }
        }

        public Room()
        {
            this.listGamers = new List<Gamer>();
            this.listQuestions = new List<Question>();
        }
    }
}
