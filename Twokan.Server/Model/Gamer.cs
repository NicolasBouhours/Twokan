namespace Twokan.Server.Model
{
    using System;

    public class Gamer
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public int Score { get; set; }

        /// <summary>
        ///     Constructeur
        /// </summary>
        /// <param name="paramId">parametre identifiant</param>
        /// <param name="paramName">Prametre Nom</param>
        /// <param name="paramScore">Parametre Score</param>
        public Gamer(int paramId, String paramName,int paramScore)
        {
            this.Id = paramId;
            this.Name = paramName;
            this.Score = paramScore;
        }
    }
}
