using AutoMapper;
using OrganizeYourCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourCourses
{
    public class OrganizeYourCoursesMappingProfile : Profile
    {

        public OrganizeYourCoursesMappingProfile()
        {
            CreateMap<CategoryDto, Category>();
        }

    }
}
