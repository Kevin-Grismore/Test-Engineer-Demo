using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesGame.Models
{
    public class Game
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        //Regex match: Starts with at least one capital letter, ends with 0 more letters 
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        //Regex match: EC, E, E10+, T, M, or A
        [RegularExpression(@"[EC|E|E10+|T|M|A]")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }

        public bool CanBePlayedAtAge(int age)
        {
            if (Rating == "EC" || Rating == "E")
            {
                return true;
            }

            if (Rating == "E10+" && age >= 10)
            {
                return true;
            }

            if (Rating == "T" && age >= 13)
            {
                return true;
            }

            if (Rating == "M" && age >= 17)
            {
                return true;
            }

            if(Rating == "A" && age >= 18)
            {
                return true;
            }

            return false;
        }
    }
}