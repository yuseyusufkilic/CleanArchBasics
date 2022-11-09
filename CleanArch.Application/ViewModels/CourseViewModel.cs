using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace CleanArch.Application.ViewModels
{
    //entitylerimiz için bir maske. entityleri presentationa taşıyor gibi. örneğin kursları sergiliycez kurs collectionu.
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}
