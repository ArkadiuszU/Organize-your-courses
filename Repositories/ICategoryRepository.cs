using OrganizeYourCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourCourses.Repositories
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories();
        public IEnumerable<Category> GetActiveCategories();
        public Category GetCategoryById(int id);
        public bool ActiveSelectedCategory(int id);
        public bool RemoveSelectedCategory(int id);
        public bool EditSelectedCategory(Category category);
        public bool CreateNewCategory(Category category);
    }
}
