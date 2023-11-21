using System.ComponentModel.DataAnnotations;

namespace EdTech.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }

        public int AuthorId { get; set; }

        [Required]
        public string CourseName { get; set; }
        [Required]
        public string CourseDesc { get; set; }
        [Required]
        public string CourseImage { get; set; }

        public int? CourseOrder { get; set; }
        public string SubjectName { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public bool isDeleted { get; set; }

        public List<Subjects> Subjects { get; set; }
        public List<Enrollment> Enrollments { get; set; }

    }
}
