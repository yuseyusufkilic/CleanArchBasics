using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    //repo ile course'i alıyoz. service gönderiyoruz orda mapping yapılcak.
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        void AddCourse(Course course);
        void DeleteCourse(string name);
    }
}
