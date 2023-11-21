namespace EdTech.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int SubjectId { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public Subjects? Subjects { get; set; }
        public Courses? Courses { get; set; }
        public Users? Users { get; set; }
    }
}
