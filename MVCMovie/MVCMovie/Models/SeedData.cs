using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCMovie.Data;
using System;
using System.Linq;

namespace MVCMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-20"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 14.99M
                    },

                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2013-10-9"),
                        Genre = "Thriller",
                        Rating = "PG-13",
                        Price = 14.99M
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2015-2-26"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 2.50M
                    },

                    new Movie
                    {
                        Title = "The Testaments: Of One Fold and One Sheperd",
                        ReleaseDate = DateTime.Parse("2000-3-24"),
                        Genre = "Drama",
                        Rating = "Unrated",
                        Price = 1.13M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
