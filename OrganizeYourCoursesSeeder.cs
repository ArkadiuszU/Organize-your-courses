using OrganizeYourCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourCourses
{
    public class OrganizeYourCoursesSeeder
    {
        private readonly OrganizeYourCoursesDbContext dbContext;

        public OrganizeYourCoursesSeeder(OrganizeYourCoursesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Seed()
        {
            if (dbContext.Database.CanConnect())
            {
                if (!dbContext.Categories.Any())
                {
                    var categories = GetPredefinedCategories();
                    dbContext.Categories.AddRange(categories);
                    dbContext.SaveChanges();
                }
            }
        }
        private IEnumerable<Category> GetPredefinedCategories()
        {
            List<Category> categories = new List<Category>() {
                new Category { Name = "Foreign languages", ImgPath="language-category.png",  Color ="#17A2B8", IsPredefined=true},
                new Category { Name = "Programing", ImgPath= "programing-category.png",  Color ="#03DAC6",IsPredefined=true },
                new Category { Name = "Cooking", ImgPath="cooking-category.png" ,  Color ="#EB526E", IsPredefined=true},
                new Category { Name = "Music", ImgPath="music-category.png" ,  Color ="#9FEF92", IsPredefined=true},
                new Category { Name = "Economy", ImgPath="economy-category.png",  Color ="#F2C178", IsPredefined=true },
                new Category { Name = "Art", ImgPath="art-category.png",  Color ="#FF8CD8"}
            };

            return categories;
        }
    }
}
