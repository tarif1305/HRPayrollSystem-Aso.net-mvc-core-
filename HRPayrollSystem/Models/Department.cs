using System.ComponentModel.DataAnnotations;

namespace HRPayrollSystem.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Department name is required")]
        [StringLength(50, ErrorMessage = "Department name cannot exceed 50 characters")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Description cannot exceed 200 characters")]
        public string Description { get; set; }

        // Navigation property
        public virtual IList<Employee> Employees { get; set; } = new List<Employee>();
    }
}