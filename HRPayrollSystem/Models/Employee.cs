using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRPayrollSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Employee name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required]
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        [Required]
        [ForeignKey("Position")]
        public int PositionId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BasicSalary { get; set; }

        // Navigation properties
        public virtual Department? Department { get; set; }
        public virtual Position? Position { get; set; }
        public virtual IList<Payroll> Payrolls { get; set; } = new List<Payroll>();
        public virtual IList<Attendance> Attendances { get; set; } = new List<Attendance>();
    }
}
