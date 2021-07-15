using Microsoft.AspNet.Identity;
using NguyenNguyenPhuong_1811063092_Lab45.DTOs;
using NguyenNguyenPhuong_1811063092_Lab45.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AuthorizeAttribute = System.Web.Mvc.AuthorizeAttribute;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace NguyenNguyenPhuong_1811063092_Lab45.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        //public IHttpActionResult Attend ([FromBody] int courseId)
        //{
        //    var userId = User.Identity.GetUserId();
        //    if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == courseId))
        //        return BadRequest("The Attendance already exists!");
        //        var attendance = new Attendance
        //        {
        //            CourseId = courseId,
        //            AttendeeId = userId
        //    };
        //    _dbContext.Attendances.Add(attendance);
        //    _dbContext.SaveChanges();
        //    return Ok();
        //}
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("The Attendance already exists!");
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
