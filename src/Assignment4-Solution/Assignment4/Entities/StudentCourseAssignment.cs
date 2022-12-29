using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Entities
{
    public class StudentCourseAssignment
    {
        public int? StudentId { get; set; }
        public User Student { get; set; }

        public int? CourseId { get; set; }
        public Course Course { get; set; }
    }
}
