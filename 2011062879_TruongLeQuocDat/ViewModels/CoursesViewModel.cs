using _2011062879_TruongLeQuocDat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2011062879_TruongLeQuocDat.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}