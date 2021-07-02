using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourCourses.Controllers
{
    public class SportsFieldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
