using System;
using System.Collections.Generic;

namespace SMTI_Teacher_Course_Management.Models
{
    public partial class Employees
    {
        public Employees()
        {
            CourseAssignments = new HashSet<CourseAssignments>();
        }

        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }

        public virtual Users Users { get; set; }
        public virtual ICollection<CourseAssignments> CourseAssignments { get; set; }
    }
}
