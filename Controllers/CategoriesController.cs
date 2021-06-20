using Microsoft.AspNetCore.Mvc;
using OrganizeYourCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourCourses.Controllers
{
    public class CategoriesController : Controller
    {
        private static List<Category> categories = new List<Category>() {
            new Category { Id = 1, Name = "Foreign languages", ImgPath="language-category.png",  Color ="#17A2B8", IsPredefined=true},
            new Category { Id = 2, Name = "Programing", ImgPath= "programing-category.png",  Color ="#03DAC6",IsPredefined=true },
            new Category { Id = 3, Name = "Cooking", ImgPath="cooking-category.png" ,  Color ="#EB526E", IsPredefined=true},
            new Category { Id = 4, Name = "Music", ImgPath="music-category.png" ,  Color ="#9FEF92", IsPredefined=true},
            new Category { Id = 5, Name = "Economy", ImgPath="economy-category.png",  Color ="#F2C178", IsPredefined=true },
            new Category { Id = 6, Name = "Art", ImgPath="art-category.png",  Color ="#FF8CD8"}

        };
        public IActionResult Index()
        {
            return View(categories.Where(item => item.Active));
        }

        public IActionResult Select()
        {
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category model)
        {
            model.Id = categories.Count() + 1;
            model.Active = true;
            categories.Add(model);
            return RedirectToAction(nameof(Select));
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            categories.Remove(category);
            return RedirectToAction(nameof(Select));
        }

        [HttpPost]
        public IActionResult Active(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            category.Active = !category.Active;
            return RedirectToAction(nameof(Select));
        }


    }
}
