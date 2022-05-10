using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb_2___LINQ.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        public string FirstName { get; set; }

        
        public int CourseID { get; set; }
        
        public int ClassID { get; set; }


        public static List<Teacher> GetTeachers()
        {
            return new List<Teacher>()
            {
                new Teacher{ TeacherID = 1, FirstName = "Anas", ClassID = 1, CourseID = 1},
                new Teacher{ TeacherID = 2, FirstName = "Reidar", ClassID = 2 , CourseID = 2 },
                new Teacher{ TeacherID = 3, FirstName = "Tobias", ClassID = 3 , CourseID = 3 },
            };
        }
    }

   
}
