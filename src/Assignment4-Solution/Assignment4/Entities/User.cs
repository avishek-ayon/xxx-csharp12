using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public UserStatus UserType { get; set; }
        public List<Course> Courses { get; set; }

        public List<StudentCourseAssignment> StudentCourses { get; set; }
    }
}
