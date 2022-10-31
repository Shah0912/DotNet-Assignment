using System.ComponentModel.DataAnnotations;

namespace EmployeeMVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [FirstNameValidation]
        public string FirstName { get; set; }

        [StringLength(20, ErrorMessage = "Last name length must not exceed 20")]
        public string LastName { get; set; }
        
        public int? Salary { get; set; }

        public override string ToString()
        {
            return $"<Employee Id={Id}>";
        }
    }

    // Custom validator
    public class FirstNameValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("First name is required");
            }
            else if (value.ToString().Contains("@"))
            {
                return new ValidationResult("First name should not contain @");
            }
            return ValidationResult.Success;
        }
    }
}
