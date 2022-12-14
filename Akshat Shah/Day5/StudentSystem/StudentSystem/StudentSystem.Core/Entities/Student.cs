using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Core.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Name must not exceed 50 characters")]
        public string Name { get; set; }

        [Range(0.0, 10.0, ErrorMessage = "Gpa must be between 0.0 and 10.0")]
        public float Gpa { get; set; }

        [Required]
        // [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Email address not valid")]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
