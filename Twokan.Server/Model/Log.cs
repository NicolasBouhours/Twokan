namespace Twokan.Server.Model
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    public class Log
    {
        public string Action { get; set; }

        public DateTime Date { get; set; }

        public Gamer Client { get; set; } 
    }
}
