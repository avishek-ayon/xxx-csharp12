using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int Fees { get; set; }
        public int? TeacherId { get; set; }
        public User? Teacher { get; set; }

        public List<StudentCourseAssignment> CourseStudents { get; set; }
    }
}
