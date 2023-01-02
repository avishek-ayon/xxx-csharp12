﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Entities
{
    public class ClassSchedules
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
