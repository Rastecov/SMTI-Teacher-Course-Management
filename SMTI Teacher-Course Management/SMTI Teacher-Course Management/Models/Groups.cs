using System;
using System.Collections.Generic;

namespace SMTI_Teacher_Course_Management.Models
{
    public partial class Groups
    {
        public Groups()
        {
            CourseAssignments = new HashSet<CourseAssignments>();
        }

        public int GroupNumber { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CourseAssignments> CourseAssignments { get; set; }
    }
}
