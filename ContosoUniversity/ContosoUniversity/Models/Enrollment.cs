using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; } //foreign key, correspoind navigation property is Course
        public int StudentID { get; set; } //foreign key, corresponding navigation property is Student
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; } // ? indicates nullable

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}