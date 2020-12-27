using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesGame.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
    }
}