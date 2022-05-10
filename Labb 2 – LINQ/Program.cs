using Labb_2___LINQ.Data;
using System;
using System.Linq;

namespace Labb_2___LINQ
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            SUT21DbContext context = new SUT21DbContext();

            Console.WriteLine("Labb 2 LINQ Mattias");

            var matematik = context.Teachers.
                Join(context.Courses,
                Teach => Teach.TeacherID,
                Cour => Cour.CourseID,
                (TeachName,CourName) => new 
                { 
                  TName = TeachName.FirstName,
                  CName = CourName.CourseName 
                }).
                  Where(x=> x.CName == "Math").Distinct().ToList();

            foreach (var m in matematik)
            {
                Console.WriteLine("Lärare "+ m.TName + " lär ut " + m.CName);
            }


            Console.WriteLine("Elever tillsammans med sina lärare");

            var studteach = context.Teachers.
                Join(context.Courses,
                TName => TName.TeacherID,
                CourTeach => CourTeach.TeacherID,
                (TName, CourTeach) => new
                {
                    TName,
                    CourTeach
                }).Join(context.Students,
                    StudCour => StudCour.CourTeach.StudentID,
                    Stud => Stud.StudentID,
                    (StudCour, Stud) => new
                    {
                        StudCour,
                        Stud
                    }).Select(x => new
                    {
                        TeacherName = x.StudCour.TName.FirstName,
                        StudentName = x.Stud.FirstName,
                    }
                    ).ToList();

            foreach (var item in studteach)
            {
                Console.WriteLine("Lärare " + item.TeacherName + " har elev " + item.StudentName);
            }


            Console.WriteLine("Course innehåller programmering1? ");


            var containsProgrammering1 = context.Courses.Select(x => x.CourseName).Contains("Programmering1");


            
            Console.WriteLine("Innerhåller programmering1 = " + containsProgrammering1);

            Console.WriteLine("Editerar från programmering2 till OOP");

            foreach (var item in context.Courses.Where(x => x.CourseName=="Programmering2"))
            {
                item.CourseName = "OOP";
               
            }

            context.SaveChanges();

            Console.WriteLine("Klart med editering till OOP från Programmering2");

            Console.WriteLine("Ändrar elevens lärare från Anas till Reidar");

            foreach (var item in context.Courses.Where(x=> x.TeacherID==1))
            {
                item.TeacherID = 2;
            }
            context.SaveChanges();

            Console.WriteLine("Klar med kurseditering från Anas till Reidar");
            Console.ReadKey();  
                
        }
    }
}
