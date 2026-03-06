using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem2.Models
{
    public class Student
    {
        public int ID { get; set; }

        
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }   
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string? Photopath { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        
        public string Gender { get; set; }
        public DateTime EnrollmentDate{ get; set; }
    }
}
