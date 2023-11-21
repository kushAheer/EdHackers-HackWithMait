using System.ComponentModel.DataAnnotations;

namespace EdTech.Models
{
    public class Subjects
    {
        [Key]
        public int SubjectId { get; set; }
        [Required]
        public string SubjectName { get; set; }
        [Required]
        public string SubjectDesc { get; set; }
        public Courses? Courses { get; set; }
    }
}
