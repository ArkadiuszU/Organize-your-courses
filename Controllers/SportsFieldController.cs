using Microsoft.AspNetCore.Mvc;
using OrganizeYourCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourCourses.Controllers
{
    public class SportsFieldController : Controller
    {
        public static List<SportField> sportFields = new List<SportField>
        {
            new SportField
            {
                Type = SportFieldType.football,
                Name = "Orlik",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
                Features = new SportFieldFeature
                {
                    Lighting = true,
                    Cloakroom = true,
                    ArtificalTurf = false,
                    EquipmentRental = true
                },
                City = "Poznań",
                Street = "Wojskowa",
                Number = "9g",
                PhoneNumber = 601901564,
                Email = "sample@sample.com"
            },
            new SportField
            {
                Type = SportFieldType.basketball,
                Name = "Wielofunkcyjne",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
                Features = new SportFieldFeature
                {
                    Lighting = true,
                    Cloakroom = true,
                    ArtificalTurf = true,
                    EquipmentRental = false
                },
                City = "Poznań",
                Street = "Wojskowa",
                Number = "15",
                PhoneNumber = 601901564,
                Email = "sample@sample.com"
            },
            new SportField
            {
                Type = SportFieldType.volleyball,
                Name = "Plazowe",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
                Features = new SportFieldFeature
                {
                    Lighting = false,
                    Cloakroom = false,
                    ArtificalTurf = false,
                    EquipmentRental = true
                },
                City = "Poznań",
                Street = "Świętego Wawrzyńca",
                Number = "3b",
                PhoneNumber = 601901564,
                Email = "sample@sample.com"
            },
    };
        
        public IActionResult Index()
        {
            return View(sportFields);
        }
        public IActionResult Details()
        {
            return View(sportFields[2]);
        }
    }
}
