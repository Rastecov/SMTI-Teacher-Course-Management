using Microsoft.EntityFrameworkCore;

namespace SMTI_Teacher_Course_Management.Models
{
    public class TeacherCourseAssignment
    {
        public int AssignId { get; set; }
        public int EmployeeNumber { get; set; }
        public string CourseNumber { get; set; }
        public int GroupNumber { get; set; }



    }
}
