using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContossoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [Display(Name = "Enrollment Date:"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}