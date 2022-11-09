using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _mediator;

        public CourseService(ICourseRepository courseRepository,IMediatorHandler mediator)
        {
            _courseRepository = courseRepository;
            _mediator = mediator;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(courseViewModel.Name,courseViewModel.Description,courseViewModel.ImageUrl);
            _mediator.SendCommand(createCourseCommand);
        }

        public void Delete(CourseViewModel courseViewModel)
        {
            var deleteCourseCommand = new DeleteCourseCommand(courseViewModel.Name);
            _mediator.SendCommand(deleteCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel() { Courses = _courseRepository.GetCourses() };          

        }
    }
}
