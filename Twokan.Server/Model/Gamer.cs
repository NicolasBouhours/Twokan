using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twokan.Server.Model
{
    public class Gamer
    {
        private int id;

        private String name;

        private int score;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public Gamer(int id, String name,int score)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }
    }
}
