using Labb_2___LINQ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___LINQ.Data
{
    public class SUT21DbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student>Students { get; set; }
        public DbSet<Class>Classes { get; set; }
        public DbSet<Course>Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-SVBPE2B; database = MySchool; Trusted_Connection = True");
        }
    }
}
