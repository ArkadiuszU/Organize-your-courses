using OrganizeYourCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourCourses.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly OrganizeYourCoursesDbContext dbContext;

        public CategoryRepository(OrganizeYourCoursesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Category> GetActiveCategories()
        {
            var result = dbContext.Categories.ToList();

            return result;
        }
    }
}
