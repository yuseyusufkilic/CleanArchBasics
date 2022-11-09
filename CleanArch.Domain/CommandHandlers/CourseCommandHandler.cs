using CleanArch.Domain.Commands;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>,IRequestHandler<DeleteCourseCommand, bool>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository= courseRepository;
        }
        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course() { 
                Name= request.Name,
                Description= request.Description,
                ImageUrl= request.ImageUrl,

            };

            _courseRepository.AddCourse(course);
            return Task.FromResult(true);
        }

        public Task<bool> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
        {
            _courseRepository.DeleteCourse(request.Name);
            return Task.FromResult(true);
        }
    }
}
