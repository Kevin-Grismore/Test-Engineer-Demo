using Microsoft.EntityFrameworkCore;

namespace RazorPagesGame.Data
{
    public class RazorPagesGameContext : DbContext
    {
        public RazorPagesGameContext(DbContextOptions<RazorPagesGameContext> options) : base(options)
        {

        }

        public DbSet<RazorPagesGame.Models.Game> Game { get; set; }
    }
}