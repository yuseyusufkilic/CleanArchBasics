﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Commands
{
    public class DeleteCourseCommand:CourseCommand
    {
        public DeleteCourseCommand(string name)
        {
            Name= name;
        }
    }
}
