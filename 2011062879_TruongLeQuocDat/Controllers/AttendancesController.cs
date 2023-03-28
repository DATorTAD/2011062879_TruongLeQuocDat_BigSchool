using _2011062879_TruongLeQuocDat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using _2011062879_TruongLeQuocDat.DTOs;

namespace _2011062879_TruongLeQuocDat.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
            {
                _dbContext = new ApplicationDbContext() ;
            }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var useId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == useId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("THE ATTENDANCE ALREADY EXISTS");
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = useId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
   
}
