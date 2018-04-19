namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.DatabaseContext.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.DatabaseContext.Context context)
        {
            context.Movies.AddOrUpdate(new Models.Movie[] {
                new Models.Movie
                {
                    Title = "Annihilation",
                    Genre = "Fantasy",
                    YearReleased = 2018,
                    Tagline = "Fear what's inside.",
                    Rating = 9.0m

                },
                    new Models.Movie
                {
                    Title = "Rogue One",
                    Genre = "Sci-Fi",
                    YearReleased = 2016,
                    Tagline = "A rebellion built on hope.",
                    Rating = 8.9m
                    },
                    new Models.Movie
                {
                    Title = "Melancholia",
                    Genre = "Drama",
                    YearReleased = 2011,
                    Tagline = "It will change everything.",
                    Rating = 8.8m
                    },
                     new Models.Movie
                {
                    Title = "The Life of Brian",
                    Genre = "Comedy",
                    YearReleased = 1979,
                    Tagline = "Honk if you love Brian.",
                    Rating = 9.1m
                     },
                      new Models.Movie
                     {
                    Title = "The Neverending Story",
                    Genre = "Fantasy",
                    YearReleased = 1984,
                    Tagline = "A boy who needs a friend finds a world that needs a hero, in a land beyond imagination.",
                    Rating = 10.0m
                     },
            });

        }
    }
}

