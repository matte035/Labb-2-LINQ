using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb_2___LINQ.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }

        public string ClassName { get; set; }
        
        public int StudentID { get; set; }

        

        public static List<Class> GetClasses()
        {
            return new List<Class>()
            {
                new Class{ ClassID = 1, ClassName ="SUT21", StudentID = 1 },
                new Class{ ClassID = 2, ClassName ="SUT22", StudentID=2 },
                
                
            };
        }
    }
}
