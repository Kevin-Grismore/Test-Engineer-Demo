using System;

namespace Framework.Models
{
    public class Uncharted2Game : Game
    {
        public override int ID { get; set; } = 2;

        public override string Title { get; set; } = "Uncharted 2";

        public override DateTime ReleaseDate { get; set; } = DateTime.Parse("2009-10-13");

        public override string Genre { get; set; } = "action-adventure";

        public override decimal Price { get; set; } = 59.99M;

        public override string Rating { get; set; } = "T";
    }
}