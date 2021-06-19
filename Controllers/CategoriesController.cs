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
            new Category { Id = 1, Name = "Foreign languages", ImgPath="language-category.png",  Color ="#17A2B8"},
            new Category { Id = 2, Name = "Programing", ImgPath= "programing-category.png",  Color ="#03DAC6" },
            new Category { Id = 3, Name = "Cooking", ImgPath="cooking-category.png" ,  Color ="#EB526E"},
            new Category { Id = 4, Name = "Music", ImgPath="music-category.png" ,  Color ="#9FEF92"},
            new Category { Id = 5, Name = "Economy", ImgPath="economy-category.png",  Color ="#F2C178" },
            new Category { Id = 5, Name = "Art", ImgPath="art-category.png",  Color ="#FF8CD8" }

        };
        public IActionResult Index()
        {
            return View(categories.Where(item => item.Active));
        }

        public IActionResult Select()
        {
            return View(categories);
        }

       [HttpPost]
        public IActionResult Active(int id)
        {
            categories.FirstOrDefault(c => c.Id == id).Active = true;
            return RedirectToAction(nameof(Index));
        }
    }
}
