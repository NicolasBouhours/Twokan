﻿namespace Twokan.Server.Model
{
    using System.Collections.Generic;

    public class Room
    {
        public Room()
        {
            this.ListGamers = new List<Gamer>();
            this.ListQuestions = new List<Question>();
        }

        public int Id { get; set; }

        public ICollection<Question> ListQuestions { get; }

        public ICollection<Gamer> ListGamers { get; }
    }
}
