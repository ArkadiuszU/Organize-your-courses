using AutoMapper;
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
        private readonly IMapper mapper;

        public CategoryRepository(OrganizeYourCoursesDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public IEnumerable<Category> GetActiveCategories()
        {
            var result = dbContext.Categories.Where(c => c.Active);
            return result;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            var result = dbContext.Categories.ToList();
            return result;
        }

        public Category GetCategoryById(int id)
        {
            var result = dbContext.Categories.FirstOrDefault(c => c.Id == id);
            return result;
        }
        public bool ActiveSelectedCategory(int id)
        {
            var category = GetCategoryById(id);
            if (category is null)
            {
                return false;
            }
            else
            {
                category.Active = !category.Active;
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool EditSelectedCategory(CategoryDto category)
        {
            var selectedCategory = GetCategoryById(category.Id);
            if (selectedCategory is null)
            {
                return false;
            }
            else
            {
                selectedCategory.Name = category.Name;
                selectedCategory.Description = category.Description;
                selectedCategory.Color = category.Color;
                dbContext.SaveChanges();
                return true;
            }
           
        }

        public bool CreateNewCategory(CategoryDto category)
        {
            if (category is null)
            {
                return false;
            }
            else
            {
               
                Category newCategory = mapper.Map<Category>(category);
                newCategory.Active = true;
                dbContext.Categories.Add(newCategory);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool RemoveSelectedCategory(int id)
        {
            var selectedCategory = GetCategoryById(id);
            if (selectedCategory is null)
            {
                return false;
            }
            else
            {
                dbContext.Categories.Remove(selectedCategory);
                dbContext.SaveChanges();
                return true;
            }
        }
    }
}
