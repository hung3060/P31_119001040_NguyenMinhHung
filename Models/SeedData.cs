using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Category == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Category.Any())
                {
                    return;   // DB has been seeded
                }

                context.Category.AddRange(
                    new Category
                    {
                        ID = 1 ,
                        Name = "Nguyen Minh 1"
                    },

                    new Category
                    {
                        ID = 2 ,
                        Name = "Nguyen Minh 1"
                    },

                    new Category
                    {
                        ID = 3 ,
                        Name = "Nguyen Minh 1"
                    },

                    new Category
                    {
                        ID = 4 ,
                        Name = "Nguyen Minh 1"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}