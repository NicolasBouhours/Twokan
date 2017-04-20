using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twokan.Server.Model
{
    public class Room
    {
        private int id;

        private List<Question> listQuestions;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public List<Question> ListQuestions
        {
            get { return listQuestions; }
            set { listQuestions = value; }
        }
    }
}
