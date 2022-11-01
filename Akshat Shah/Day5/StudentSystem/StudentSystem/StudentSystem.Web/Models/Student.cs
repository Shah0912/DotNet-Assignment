using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Web.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Student ID")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Email address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [DisplayName("GPA")]
        [Range(0.0, 10.0)]
        public float Gpa { get; set; }
    }
}
