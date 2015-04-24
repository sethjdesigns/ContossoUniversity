using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContossoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "First Name")][StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Column("FirstName")]
        [Required]
        public string FirstMidName { get; set; }
        [Display(Name = "Enrollment Date:"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}