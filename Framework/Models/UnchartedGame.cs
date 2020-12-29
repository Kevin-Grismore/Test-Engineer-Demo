using System;

namespace Framework.Models
{
    public class UnchartedGame : Game
    {
        public override int ID { get; set; } = 1;

        public override string Title { get; set; } = "Uncharted";

        public override DateTime ReleaseDate { get; set; } = DateTime.Parse("2007-11-19");

        public override string Genre { get; set; } = "action-adventure";

        public override decimal Price { get; set; } = 59.99M;

        public override string Rating { get; set; } = "T";
    }
}