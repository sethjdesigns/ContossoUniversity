using System.ComponentModel.DataAnnotations;
namespace ContossoUniversity.Models
{
    public enum Grade
    {
        A = 4, B = 3, C = 2, D = 1, F = 0
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
