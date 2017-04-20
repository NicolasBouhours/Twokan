﻿namespace Twokan.Server.Model
{
    using System;

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

        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="paramId">parametre identifiant</param>
        /// <param name="paramName">Prametre Nom</param>
        /// <param name="paramScore">Parametre Score</param>
        public Gamer(int paramId, String paramName,int paramScore)
        {
            this.id = paramId;
            this.name = paramName;
            this.score = paramScore;
        }
    }
}
