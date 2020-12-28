using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesGame.Data;
using System;
using System.Linq;

namespace RazorPagesGame.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesGameContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesGameContext>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game 
                    {
                        Title = "Uncharted",
                        ReleaseDate = DateTime.Parse("2007-11-19"),
                        Genre = "action-adventure",
                        Price = 59.99M,
                        Rating = "T"
                    },

                    new Game
                    {
                        Title = "Uncharted 2",
                        ReleaseDate = DateTime.Parse("2009-10-13"),
                        Genre = "action-adventure",
                        Price = 59.99M,
                        Rating = "T"
                    },

                    new Game
                    {
                        Title = "Uncharted 3",
                        ReleaseDate = DateTime.Parse("2011-11-1"),
                        Genre = "action-adventure",
                        Price = 59.99M,
                        Rating = "T"
                    },

                    new Game
                    {
                        Title = "Uncharted 4",
                        ReleaseDate = DateTime.Parse("2016-5-10"),
                        Genre = "action-adventure",
                        Price = 59.99M,
                        Rating = "T"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}