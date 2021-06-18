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
            new Category { MyPropertyInt = 12, MyPropertyString = "noaJak" },
            new Category { MyPropertyInt = 14, MyPropertyString = "aaa" },
            new Category { MyPropertyInt = 124, MyPropertyString = "ff" }
        };
        public IActionResult Index()
        {
            return View(categories);
        }
    }
}
