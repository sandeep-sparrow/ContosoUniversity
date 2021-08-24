using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        // we will add properties of Student in Student.cs model
        // ID will be come the primary key of Student table
        public int ID { get; set; } 
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Enrollments property is a navigation property
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}