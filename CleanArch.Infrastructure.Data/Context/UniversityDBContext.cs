using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace CleanArch.Infrastructure.Data.Context
{
    //bu dbcontext'i biz yazdık. MVC içindeki .net core ile gelen identity db.
    public class UniversityDBContext :DbContext
    {
        public UniversityDBContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }

    }
}
