
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem2.Models
{
    public class Teacher
    {
        public int ID{ get; set; }
        [Required]
        [StringLength(100)]
        
        public string FirstName{ get; set; }
        [Required]
        [StringLength(100)]
        public string LastName{ get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber{ get; set; }
        public string? Photopath { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public DateTime HireDate{ get; set; } 
}
}
