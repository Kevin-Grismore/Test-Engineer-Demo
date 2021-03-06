using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesGame.Data;
using RazorPagesGame.Models;

namespace RazorPagesGame.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesGame.Data.RazorPagesGameContext _context;

        public DetailsModel(RazorPagesGame.Data.RazorPagesGameContext context)
        {
            _context = context;
        }

        public Game Game { get; set; }

        [BindProperty(SupportsGet = true)]
        [RegularExpression(@"^[0-9]+$")]
        [Required]
        public string AgeString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CanPlay { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Game.FirstOrDefaultAsync(m => m.ID == id);

            if (Game == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (!string.IsNullOrEmpty(AgeString))
            {
                if(Game.CanBePlayedAtAge(Int32.Parse(AgeString)))
                {
                    CanPlay = "Yes";
                }

                else
                {
                    CanPlay = "No";
                }
            }

            return Page();
        }
    }
}
