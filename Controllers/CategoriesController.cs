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
        List<Category> categories = new List<Category>() {
            new Category { Id = 1, Name = "Foreign languages", ImgPath="language-category.png"},
            new Category { Id = 2, Name = "Programing", ImgPath= "programing-category.png" },
            new Category { Id = 3, Name = "Cooking", ImgPath="cooking-category.png" },
            new Category { Id = 4, Name = "Music", ImgPath="music-category.png" },
            new Category { Id = 5, Name = "Economy", ImgPath="economy-category.png" },
            new Category { Id = 5, Name = "Art", ImgPath="art-category.png" }


        };
        public IActionResult Index()
        {
            return View(categories.Where(item=>item.Active));
        }
    }
}
