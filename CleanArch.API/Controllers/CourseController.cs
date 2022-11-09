using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult CreatePost([FromBody] CourseViewModel courseViewModel)
        {
            _courseService.Create(courseViewModel);
            return Ok(courseViewModel);
        }

        [HttpDelete]
        public IActionResult DeletePost([FromBody] CourseViewModel courseViewModel)
        {
            _courseService.Delete(courseViewModel);
            return Ok();
        }
       
    }
}
