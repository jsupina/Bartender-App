using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace BartenderApp.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Red Wine",
                    Category = "Wine",
                    Price = 275
                },
                new Product
                {
                    Name = "White Wine",
                    Category = "Wine",
                    Price = 48.95m
                },
                new Product
                {
                    Name = "Bud Light",
                    Category = "Beer",
                    Price = 19.50m
                },
                new Product
                {
                    Name = "Guinness",
                    Category = "Beer",
                    Price = 34.95m
                },
                new Product
                {
                    Name = "Long Island Iced Tea",
                    Category = "Cocktail",
                    Price = 79500
                },
                new Product
                {
                    Name = "Cosmopolitan",
                    Category = "Cocktail",
                    Price = 16
                },
                new Product
                {
                    Name = "Jack Daniels",
                    Category = "Liqueurs",
                    Price = 29.95m
                },
                new Product
                {
                    Name = "Jagermeister",        
                    Category = "Liqueurs",
                    Price = 75
                },
                new Product
                {
                    Name = "Tester",
                    Category = "Liqueurs",
                    Price = 75
                }
                );
                context.SaveChanges();
            }
        }
    }
}