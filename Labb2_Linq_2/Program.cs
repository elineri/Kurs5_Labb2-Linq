using Labb2_Linq_2.Data;
using Labb2_Linq_2.Models;
using System;

namespace Labb2_Linq_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //using SchoolDbContext Context = new SchoolDbContext();

            //Subject sub1 = new Subject() { SubjectName = "Development with C#" };
            //Subject sub2 = new Subject() { SubjectName = "Programming2" };
            //Subject sub3 = new Subject() { SubjectName = "Advanced .NET" };
            //Subject sub4 = new Subject() { SubjectName = "Statistics A1" };
            //Subject sub5 = new Subject() { SubjectName = "Statistics A2" };
            //Subject sub6 = new Subject() { SubjectName = "Economics" };
            //Subject sub7 = new Subject() { SubjectName = "Leadership" };
            //Subject sub8 = new Subject() { SubjectName = "Mathematics" };
            //Subject sub9 = new Subject() { SubjectName = "Sustainable development" };
            //Context.Add(sub1);
            //Context.Add(sub2);
            //Context.Add(sub3);
            //Context.Add(sub4);
            //Context.Add(sub5);
            //Context.Add(sub6);
            //Context.Add(sub7);
            //Context.Add(sub8);
            //Context.Add(sub9);

            //Course c1 = new Course() { CourseName = "SUT21" };
            //Course c2 = new Course() { CourseName = "HAE21" };
            //Course c3 = new Course() { CourseName = "FSL21" };
            //Context.Add(c1);
            //Context.Add(c2);
            //Context.Add(c3);

            //Teacher t1 = new Teacher() { FirstName = "Marit", LastName = "Johansson", Role = "Lärare systemutveckling" };
            //Teacher t2 = new Teacher() { FirstName = "Bengt", LastName = "Stig", Role = "Lärare ekonomi" };
            //Teacher t3 = new Teacher() { FirstName = "Ylva", LastName = "Hammarström", Role = "Lärare förskolelärare" };
            //Teacher t4 = new Teacher() { FirstName = "Magdalena", LastName = "Andersson", Role = "Lärare systemutveckling" };
            //Teacher t5 = new Teacher() { FirstName = "Fredrik", LastName = "Reinfeldt", Role = "Lärare förskolelärare" };
            //Teacher t6 = new Teacher() { FirstName = "Göran", LastName = "Persson", Role = "Lärare ekonomi" };
            //Teacher t7 = new Teacher() { FirstName = "Lisa", LastName = "Svensson", Role = "Lärare förskolelärare" };
            //Teacher t8 = new Teacher() { FirstName = "Göran", LastName = "Svensson", Role = "Lärare systemutveckling" };
            //Context.Add(t1);
            //Context.Add(t2);
            //Context.Add(t3);
            //Context.Add(t4);
            //Context.Add(t5);
            //Context.Add(t6);
            //Context.Add(t7);
            //Context.Add(t8);

            //Student s1 = new Student() { FirstName = "Elin", LastName = "Elin", CourseId = 1 };
            //Student s2 = new Student() { FirstName = "Oskar", LastName = "Johansson", CourseId = 2 };
            //Student s3 = new Student() { FirstName = "Göran", LastName = "Skog", CourseId = 3 };
            //Student s4 = new Student() { FirstName = "Sara", LastName = "Berg", CourseId = 1 };
            //Student s5 = new Student() { FirstName = "Ola", LastName = "Stig", CourseId = 2 };
            //Student s6 = new Student() { FirstName = "Thomas", LastName = "Kristersson", CourseId = 3 };
            //Student s7 = new Student() { FirstName = "Anna", LastName = "Klasson", CourseId = 1 };
            //Student s8 = new Student() { FirstName = "Patrik", LastName = "Sten", CourseId = 2 };
            //Student s9 = new Student() { FirstName = "Moa", LastName = "Strand", CourseId = 3 };
            //Student s10 = new Student() { FirstName = "Ulla", LastName = "Bergström", CourseId = 1 };
            //Student s11 = new Student() { FirstName = "Bosse", LastName = "Falk", CourseId = 2 };
            //Student s12 = new Student() { FirstName = "Åsa", LastName = "Pil", CourseId = 3 };
            //Context.Add(s1);
            //Context.Add(s2);
            //Context.Add(s3);
            //Context.Add(s4);
            //Context.Add(s5);
            //Context.Add(s6);
            //Context.Add(s7);
            //Context.Add(s8);
            //Context.Add(s9);
            //Context.Add(s10);
            //Context.Add(s11);
            //Context.Add(s12);

            //CourseSubject cs1 = new CourseSubject() { SubjectId = 1, CourseId = 1 };
            //CourseSubject cs2 = new CourseSubject() { SubjectId = 2, CourseId = 1 };
            //CourseSubject cs3 = new CourseSubject() { SubjectId = 3, CourseId = 1 };
            //CourseSubject cs4 = new CourseSubject() { SubjectId = 4, CourseId = 2 };
            //CourseSubject cs5 = new CourseSubject() { SubjectId = 5, CourseId = 2 };
            //CourseSubject cs6 = new CourseSubject() { SubjectId = 6, CourseId = 2 };
            //CourseSubject cs7 = new CourseSubject() { SubjectId = 7, CourseId = 3 };
            //CourseSubject cs8 = new CourseSubject() { SubjectId = 8, CourseId = 3 };
            //CourseSubject cs9 = new CourseSubject() { SubjectId = 9, CourseId = 3 };
            //Context.Add(cs1);
            //Context.Add(cs2);
            //Context.Add(cs3);
            //Context.Add(cs4);
            //Context.Add(cs5);
            //Context.Add(cs6);
            //Context.Add(cs7);
            //Context.Add(cs8);
            //Context.Add(cs9);

            //SubjectTeacher st1 = new SubjectTeacher() { SubjectId = 1, TeacherId = 2 };
            //SubjectTeacher st2 = new SubjectTeacher() { SubjectId = 2, TeacherId = 5 };
            //SubjectTeacher st3 = new SubjectTeacher() { SubjectId = 3, TeacherId = 9 };
            //SubjectTeacher st4 = new SubjectTeacher() { SubjectId = 4, TeacherId = 3 };
            //SubjectTeacher st5 = new SubjectTeacher() { SubjectId = 5, TeacherId = 3 };
            //SubjectTeacher st6 = new SubjectTeacher() { SubjectId = 6, TeacherId = 7 };
            //SubjectTeacher st7 = new SubjectTeacher() { SubjectId = 7, TeacherId = 4 };
            //SubjectTeacher st8 = new SubjectTeacher() { SubjectId = 8, TeacherId = 6 };
            //SubjectTeacher st9 = new SubjectTeacher() { SubjectId = 9, TeacherId = 8 };
            //SubjectTeacher st10 = new SubjectTeacher() { SubjectId = 8, TeacherId = 8 };
            //Context.Add(st1);
            //Context.Add(st2);
            //Context.Add(st3);
            //Context.Add(st4);
            //Context.Add(st5);
            //Context.Add(st6);
            //Context.Add(st7);
            //Context.Add(st8);
            //Context.Add(st9);
            //Context.Add(st10);
            //Context.SaveChanges();
            #endregion

            Console.WriteLine($"\t *** School ****");

            bool run = true;

            while (run)
            {
                Console.WriteLine($"  [1] Math teachers\n" +
                    $"  [2] Students with teachers\n" +
                    $"  [3] Subjects contains\n" +
                    $"  [4] Update subject\n" +
                    $"  [5] Update student records with teachers\n" +
                    $"  [6] Show all teachers");
                Console.Write("  Selection: ");
                int select = Int32.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.Clear();
                        MenuOptions.MathTeachers();
                        break;
                    case 2:
                        Console.Clear();
                        MenuOptions.StudentTeachers();
                        break;
                    case 3:
                        Console.Clear();
                        MenuOptions.SubjectContains();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        MenuOptions.UpdateTeacher();
                        break;
                    case 6:
                        Console.Clear();
                        MenuOptions.GetAllTeachers();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
