using AssigmentENF.Model02;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfAssigment02.Context
{
    internal class ItiCompanyDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ItiCompanyDB;Trusted_Connection=true;TrustServerCertificate=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Course_Instructor
            modelBuilder.Entity<Course_Instructor>()
                .HasKey(ci=>ci.CourseId);
            modelBuilder.Entity<Course_Instructor>()
                .Property(c => c.InstructorId).IsRequired();
            modelBuilder.Entity<Course_Instructor>()
                .Property(c => c.Evaluation).HasMaxLength(500);

            #endregion

            #region Course
            modelBuilder.Entity<Courses>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Courses>()
                .Property(c => c.Name).IsRequired().HasMaxLength(100) ;
            modelBuilder.Entity<Courses>()
                .Property(c => c.Duration).IsRequired();
            modelBuilder.Entity<Courses>()
                .Property(c => c.Description).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Courses>()
                .Property(c => c.Top_id).IsRequired();

            #endregion

            #region Departments
            modelBuilder.Entity<Departments>()
                .HasKey(d => d.Id);
            modelBuilder.Entity<Departments>()
                .Property(d => d.DeptName).IsRequired();
            modelBuilder.Entity<Departments>()
                .Property(d => d.Hiring_Date).IsRequired().HasColumnType("data");
            modelBuilder.Entity<Departments>()
                .Property(d => d.Ins_Id).IsRequired();



            #endregion

            #region Instructor
            modelBuilder.Entity<Instructors>()
                .HasKey(i => i.Id);
            modelBuilder.Entity<Instructors>()
                .Property(i => i.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Instructors>()
                .Property(i => i.Address).HasMaxLength(100);
            modelBuilder.Entity<Instructors>()
                .Property(i => i.Bouns).IsRequired().HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Instructors>()
                .Property(i => i.Salary).IsRequired().HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Instructors>()
                .Property(i => i.Hour_Rate).IsRequired().HasColumnType("data");
            modelBuilder.Entity<Instructors>()
                .Property(i => i.Dep_Id).IsRequired();


            #endregion

            #region Stud_Course
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => sc.StudentId);
            modelBuilder.Entity<Stud_Course>()
                .Property(sc => sc.CourseId).IsRequired();
            modelBuilder.Entity<Stud_Course>()
                .Property(sc => sc.Grade).HasMaxLength(5);

            #endregion

            #region Students
            modelBuilder.Entity<Students>()
                .HasKey(s => s.Id);
            modelBuilder.Entity<Students>()
                .Property(s => s.FName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Students>()
                .Property(s => s.LName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Students>()
                .Property(s => s.Age).IsRequired();
            modelBuilder.Entity<Students>()
                .Property(s => s.Address).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Students>()
                .Property(s => s.Dept_id).IsRequired();


            #endregion

            #region Topics
            modelBuilder.Entity<Topics>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Topics>()
                .Property(t => t.Name).IsRequired().HasMaxLength(100);

            #endregion
        }

        public DbSet<Topics> Topics { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }

        public DbSet<Courses> Courses { get; set; }

        public DbSet<Instructors> Instructors { get; set; }

        public DbSet<Course_Instructor> course_Instructors { get; set; }

        public DbSet<Departments> Departments { get; set; }
    }
}

