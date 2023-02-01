using System;
using System.Collections.Generic;

namespace SMTI_Teacher_Course_Management.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string Password { get; set; }

        public virtual Employees User { get; set; }

        
    }
}
