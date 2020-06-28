using HomeWork.Data;
using HomeWork.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork
{
    public static class ApplicationBuilderExtensions
    {
        private static IEnumerable<Category> GetData()
            => new List<Category>
            {
                new Category{ Name = "Clothes", Description = ""},
                new Category{ Name = "Kitchen supplies", Description = "" },
                new Category{ Name = "Car parts", Description = "" },
                new Category{ Name = "Bike parts", Description = "" },
            };

        public static IApplicationBuilder Initialize(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var serviceProvider = serviceScope.ServiceProvider;

            var db = serviceProvider.GetRequiredService<DataBaseContext>();

            db.Database.Migrate();

            if (db.Categories.Any())
            {
                return app;
            }

            foreach (var category in GetData())
            {
                db.Categories.Add(category);
            }

            db.SaveChanges();

            return app;
        }
    }
}
