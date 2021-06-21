using OrganizeYourCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourCourses.Repositories
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetActiveCategories();
    }
}
