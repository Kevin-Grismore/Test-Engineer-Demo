using System;

namespace Framework.Models
{
    public class Game
    {
        public virtual int ID { get; set; }

        public virtual string Title { get; set; }

        public virtual DateTime ReleaseDate { get; set; }

        public virtual string Genre { get; set; }

        public virtual decimal Price { get; set; }

        public virtual string Rating { get; set; }
    }
}