using Labb2_Linq_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2_Linq_2.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<SubjectTeacher> SubjectTeachers { get; set; }
        public DbSet<CourseSubject> CourseSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = LAPTOP-FUL8DVID;Initial Catalog=Labb2_Linq_2;Integrated Security = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubjectTeacher>()
                .HasOne(s => s.Subject)
                .WithMany(st => st.SubjectTeachers)
                .HasForeignKey(si => si.SubjectId);

            modelBuilder.Entity<SubjectTeacher>()
                .HasOne(t => t.Teacher)
                .WithMany(st => st.SubjectTeachers)
                .HasForeignKey(ti => ti.TeacherId);

            modelBuilder.Entity<CourseSubject>()
                .HasOne(s => s.Subject)
                .WithMany(st => st.CourseSubjects)
                .HasForeignKey(si => si.SubjectId);

            modelBuilder.Entity<CourseSubject>()
                .HasOne(c => c.Course)
                .WithMany(st => st.CourseSubjects)
                .HasForeignKey(ci => ci.CourseId);
        }
    }
}
