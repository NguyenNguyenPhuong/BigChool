using NguyenNguyenPhuong_1811063092_Lab45.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenNguyenPhuong_1811063092_Lab45.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course>UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}