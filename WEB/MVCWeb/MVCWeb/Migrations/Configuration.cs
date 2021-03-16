namespace MVCWeb.Migrations
{
    using MVCWeb.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCWeb.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVCWeb.Models.MovieDBContext";
        }

        protected override void Seed(MVCWeb.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Rating = "PG",
                    Price = 7.99M
                }
            );
        }
    }
}
