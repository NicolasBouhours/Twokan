namespace Twokan.Server.Model
{
    using System;

    public class Gamer
    {
        
        public int Id { get; set; }

        public String Name { get; set; }

        public int Score { get; set; }

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="paramId">parameter identifiant</param>
        /// <param name="paramName">Prameter name</param>
        /// <param name="paramScore">Parameter Score</param>
        public Gamer(int paramId, string paramName, int paramScore)
        {
            this.Id = paramId;
            this.Name = paramName;
            this.Score = paramScore;
        }
    }
}
