using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Freetown",
                        ReleaseDate = DateTime.Parse("2016-6-28"),
                        Genre = "Drama",
                        Price = 7.99M,
                        Rating = "PG - 13"
                    },

                    new Movie
                    {
                        Title = "The Saratov Approach ",
                        ReleaseDate = DateTime.Parse("2013-10-01"),
                        Genre = "Drama",
                        Price = 8.99M,
                        Rating = "PG - 13"
                    },

                    new Movie
                    {
                        Title = "Forever Strong",
                        ReleaseDate = DateTime.Parse("2008-9-26"),
                        Genre = "Sport Drama",
                        Price = 9.99M,
                        Rating = "PG - 13"
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-02-01"),
                        Genre = "Comedy",
                        Price = 3.99M,
                        Rating = "PG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}