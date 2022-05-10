using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb_2___LINQ.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        
        public string CourseName { get; set; }
        
        public int TeacherID { get; set; }
        
        public int ClassId { get; set; }
        
        public int StudentID { get; set; }

        

        public static List<Course> GetCourses()
        {
            return new List<Course>()
            {
                new Course{CourseID = 1, ClassId = 1, CourseName = "Math",TeacherID = 1, StudentID = 1},
                new Course{CourseID = 2, ClassId = 2, CourseName = "Programmering1", TeacherID = 2, StudentID = 2},
                new Course{CourseID = 3, ClassId = 1, CourseName = "Programmering2", TeacherID = 1, StudentID = 3},
                new Course{CourseID = 4, ClassId = 2, CourseName ="OOP", TeacherID = 2, StudentID = 4},
            };
        }
    }
}
