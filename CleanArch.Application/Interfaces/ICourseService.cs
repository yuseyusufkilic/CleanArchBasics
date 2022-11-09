using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    //mvc bu servisle konusuyor. direkt entity vermeyiz mvc'ye viewmodeli vericez tabii ki.
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
