using System;
using System.Collections.Generic;

namespace SMTI_Teacher_Course_Management.Models
{
    public partial class CourseAssignments
    {
        public int AssignId { get; set; }
        public int EmployeeNumber { get; set; }
        public string CourseNumber { get; set; }
        public int GroupNumber { get; set; }

        public virtual Courses CourseNumberNavigation { get; set; }
        public virtual Employees EmployeeNumberNavigation { get; set; }
        public virtual Groups GroupNumberNavigation { get; set; }
    }
}
