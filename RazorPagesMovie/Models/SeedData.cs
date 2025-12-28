using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialized(IServiceProvider provider)
        {
            using var context = new RazorPagesMovieContext(provider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>());

            if (context == null || context.Movie == null)
                throw new ArgumentNullException($"Null: RazorPagesMovieContext");

            if (context.Movie.Any())
                return;

            context.Movie.AddRange(
                new Movie
                {
                    Title = "O Esterminador do Futuro",
                    Genere = "Ação - Ficção Cientifica",
                    ReleaseDate = DateTime.Parse("1987-2-12"),
                    Price = 15.50M
                },

                new Movie
                {
                    Title = "O Esterminador do Futuro 2",
                    Genere = "Ação - Ficção Cientifica",
                    ReleaseDate = DateTime.Parse("1992-4-6"),
                    Price = 9.00M
                },

                new Movie
                {
                    Title = "Ghostbusters",
                    Genere = "Comédia",
                    ReleaseDate = DateTime.Parse("1984-3-10"),
                    Price = 8.99M
                }
            );

            context.SaveChanges();
        }
    }
}
