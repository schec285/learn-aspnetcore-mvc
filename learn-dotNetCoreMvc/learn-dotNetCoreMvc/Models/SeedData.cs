using learn_dotNetCoreMvc.Data;
using Microsoft.EntityFrameworkCore;

namespace learn_dotNetCoreMvc.Models;
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new learn_dotNetCoreMvcContext(
            serviceProvider.GetRequiredService<DbContextOptions<learn_dotNetCoreMvcContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    ReleaseDate = DateTime.Parse("1994-9-10"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-3-24"),
                    Genre = "Crime",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 12.99M
                }
            );
            context.SaveChanges();
        }
    }
}