using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRPayrollSystem.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        [Required(ErrorMessage = "Position title is required")]
        [StringLength(50, ErrorMessage = "Position title cannot exceed 50 characters")]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BaseSalary { get; set; }

        [StringLength(200, ErrorMessage = "Description cannot exceed 200 characters")]
        public string Description { get; set; }

        // Navigation property
        public virtual IList<Employee> Employees { get; set; } = new List<Employee>();  
    }
}