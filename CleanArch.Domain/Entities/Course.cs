﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public int Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}