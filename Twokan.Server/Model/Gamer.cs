namespace Twokan.Server.Model
{
    using System;

    public class Gamer
    {
        public Gamer(int paramId, string paramName, int paramScore)
        {
            this.Id = paramId;
            this.Name = paramName;
            this.Score = paramScore;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Score { get; set; }
    }
}
