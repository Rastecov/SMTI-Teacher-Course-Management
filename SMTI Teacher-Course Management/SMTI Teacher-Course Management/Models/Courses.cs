using System;
using System.Collections.Generic;

namespace SMTI_Teacher_Course_Management.Models
{
    public partial class Courses
    {
        public Courses()
        {
            CourseAssignments = new HashSet<CourseAssignments>();
        }

        public string CourseNumber { get; set; }
        public string CourseTitle { get; set; }
        public int TotalHour { get; set; }

        public virtual ICollection<CourseAssignments> CourseAssignments { get; set; }
    }
}
