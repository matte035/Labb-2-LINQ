using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb_2___LINQ.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public int CourseID { get; set; }

        





        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
            new Student { StudentID = 1, FirstName = "Mattias", LastName = "Johansson", CourseID = 1,},
            new Student { StudentID = 2, FirstName = "Anna", LastName = "Andersson", CourseID = 1, },
            new Student { StudentID = 3, FirstName = "Stefan", LastName = "Savic", CourseID = 2, },
            new Student { StudentID = 4, FirstName = "Johanna", LastName = "Lundström", CourseID = 2,},
            };
           



        }
    }
}
