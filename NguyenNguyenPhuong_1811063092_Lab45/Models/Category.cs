using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenNguyenPhuong_1811063092_Lab45.Models
{
    public class Category
    {
        public List<Course> Courses { get; set; }
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}