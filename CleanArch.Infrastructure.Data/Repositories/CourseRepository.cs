using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _universityDBContext;

        public CourseRepository(UniversityDBContext universityDBContext)
        {
            _universityDBContext = universityDBContext;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _universityDBContext.Courses;
        }
    }
}
