using Assignment4.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class TrainingDbContext: DbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssembly;

        public TrainingDbContext()
        {
            _connectionString = @"Server=.\SQLEXPRESS;Database=AttendanceSystem;User Id=attendancesystem;Password=12345;";
            _migrationAssembly = Assembly.GetExecutingAssembly().GetName().Name;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, (x) => x.MigrationsAssembly(_migrationAssembly));
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourseAssignment>().ToTable("StudentCourseAssignments");

            modelBuilder.Entity<StudentCourseAssignment>().HasKey(x => new { x.CourseId, x.StudentId });
            #region many to many : Course and Student

            modelBuilder.Entity<StudentCourseAssignment>()
                .HasOne(x => x.Course)
                .WithMany(y => y.CourseStudents)
                .HasForeignKey(z => z.CourseId);


            modelBuilder.Entity<StudentCourseAssignment>()
                .HasOne(x => x.Student)
                .WithMany(y => y.StudentCourses)
                .HasForeignKey(z => z.StudentId);
            #endregion

            #region one to many : Course Teacher

            modelBuilder.Entity<Course>()
                .HasOne(x => x.Teacher)
                .WithMany(y => y.Courses)
                .HasForeignKey(x => x.TeacherId);

            #endregion

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
