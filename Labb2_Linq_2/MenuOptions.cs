using Labb2_Linq_2.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Labb2_Linq_2
{
    public class MenuOptions
    {
        public static void MathTeachers()
        {
            using SchoolDbContext Context = new SchoolDbContext();

            var MathTeachers = from r in Context.SubjectTeachers
                               join d in Context.Teachers on r.TeacherId equals d.Id
                               join s in Context.Subjects on r.SubjectId equals s.Id
                               where r.SubjectId == 8
                               orderby d.FirstName
                               select r.Teacher;

            Console.WriteLine("  Math teachers: \n");

            foreach (var item in MathTeachers)
            {
                Console.WriteLine($"  {item.FirstName} {item.LastName}");
            }
        }

        public static void StudentTeachers()
        {
            using SchoolDbContext Context = new SchoolDbContext();

            var MathTeachers = from s in Context.Students
                               join c in Context.Courses on s.CourseId equals c.Id
                               join csc in Context.CourseSubjects on c.Id equals csc.CourseId
                               join su in Context.Subjects on csc.SubjectId equals su.Id
                               join st in Context.SubjectTeachers on su.Id equals st.SubjectId
                               join t in Context.Teachers on st.TeacherId equals t.Id
                               select new 
                               { 
                                   student = s.FirstName + " " + s.LastName,
                                   teacher = t.FirstName + " " + t.LastName,
                                   subject = su.SubjectName
                               };
            Console.WriteLine("  *** Students with all teachers ***");

            foreach (var item in MathTeachers)
            {
                Console.WriteLine($"  Student:\t {item.student}\n" +
                    $"  Teacher:\t {item.teacher}\n" +
                    $"  Subject:\t {item.subject}\n");
            }
        }

        public static void SubjectContains()
        {
            using SchoolDbContext Context = new SchoolDbContext();

            bool SC = (from sub in Context.Subjects
                     select sub.SubjectName).ToList().Contains("Programming1");

            Console.WriteLine($" Subjects contains Programming1 = {SC}");
        }

        public static void UpdateSubject()
        {
            using SchoolDbContext Context = new SchoolDbContext();

            var S = (from s in Context.Subjects
                     where s.SubjectName == "Programming2"
                     select s).ToList();

            foreach (var item in S)
            {
                item.SubjectName = "OOP";
            }
        }

        public static void UpdateTeacher()
        {
            using SchoolDbContext Context = new SchoolDbContext();

            var stu = from s in Context.Students
                      orderby s.Id
                      select s;

            foreach (var item in stu)
            {
                Console.WriteLine($"{item.Id}\t {item.FirstName} {item.LastName}");
            }

            Console.Write("  Select student ID: ");
            int stuOption = Int32.Parse(Console.ReadLine());

            var Teachers = from s in Context.Students
                           join c in Context.Courses on s.CourseId equals c.Id
                           join csc in Context.CourseSubjects on c.Id equals csc.CourseId
                           join su in Context.Subjects on csc.SubjectId equals su.Id
                           join st in Context.SubjectTeachers on su.Id equals st.SubjectId
                           join t in Context.Teachers on st.TeacherId equals t.Id
                           where s.Id == stuOption && t.FirstName == "Göran" && t.LastName == "Svensson"
                           select new { st};

            Console.Clear();

            foreach (var teacher in Teachers)
            {
                teacher.st.Id = 1;
            }
        }

        public static void GetAllTeachers()
        {
            using SchoolDbContext Context = new SchoolDbContext();

            var test = from s in Context.Subjects
                       join st in Context.SubjectTeachers on s.Id equals st.SubjectId
                       join t in Context.Teachers on st.TeacherId equals t.Id
                       orderby s.SubjectName
                       select new { teacher = t.FirstName + " " + t.LastName, subject = s.SubjectName};

            foreach (var item in test)
            {

                Console.WriteLine($"{item.subject}\t {item.teacher}");
            }
        }
    }
}
