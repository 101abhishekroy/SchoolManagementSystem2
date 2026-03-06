using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem2.Models
{
    public class Course
    {
        public int Id{ get; set; }
        [Required]
        [StringLength(100)]
        public string CourseName { get; set; }
        [Required]
        [StringLength(50)]
        public string CourseCode { get; set; }
        public string Credits { get; set; }
    }
}
