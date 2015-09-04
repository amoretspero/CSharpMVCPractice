namespace amoretspero_firstmvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<amoretspero_firstmvc.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "amoretspero_firstmvc.Models.MovieDBContext";
        }

        protected override void Seed(MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "Inside Out",
                    ReleaseDate = DateTime.Parse("2015-07-09"),
                    Genre = "Animation",
                    Price = 7.99M,
                    Rating = "8.6"
                },

                new Movie
                {
                    Title = "Frozen",
                    ReleaseDate = DateTime.Parse("2014-01-16"),
                    Genre = "Animation",
                    Price = 8.99M,
                    Rating = "7.6"
                },

                new Movie
                {
                    Title = "Trouble With The Curve",
                    ReleaseDate = DateTime.Parse("2012-11-29"),
                    Genre = "Drama",
                    Price = 7.99M,
                    Rating = "6.8"
                },

                new Movie
                {
                    Title = "Les Miserables",
                    ReleaseDate = DateTime.Parse("2012-12-25"),
                    Genre = "Musical",
                    Price = 8.99M,
                    Rating = "7.6"
                },

                new Movie
                {
                    Title = "The Day After Tomorrow",
                    ReleaseDate = DateTime.Parse("2004-06-04"),
                    Genre = "Sci-Fi",
                    Price = 5.99M,
                    Rating = "6.4"
                }
            );
        }
    }
}
