using Microsoft.AspNetCore.Mvc;
using OrganizeYourCourses.Models;
using OrganizeYourCourses.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourCourses.Controllers
{
    public class CategoriesController : Controller
    {

        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var categories = categoryRepository.GetActiveCategories();
            return View(categories);
        }

        [HttpGet]
        public string GetString()
        {
            //var categories = categoryRepository.GetActiveCategories();
            return "No hej";
        }

        [HttpGet]
        public IActionResult Select()
        {
            var categories = categoryRepository.GetAllCategories();
            return View(categories);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = categoryRepository.GetCategoryById(id);
            return View(category);
        }

        
        [HttpPost]
        public IActionResult Active(int id)
        {
            categoryRepository.ActiveSelectedCategory(id);
            return RedirectToAction(nameof(Select));
        }

        [HttpPost]
        public IActionResult Edit(CategoryDto model)
        {
            categoryRepository.EditSelectedCategory(model);
            return RedirectToAction(nameof(Select));
        }

        [HttpPost]
        public IActionResult Create(CategoryDto model)
        {
            categoryRepository.CreateNewCategory(model);
            return RedirectToAction(nameof(Select));
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            categoryRepository.RemoveSelectedCategory(id);
            return RedirectToAction(nameof(Select));
        }




    }
}
