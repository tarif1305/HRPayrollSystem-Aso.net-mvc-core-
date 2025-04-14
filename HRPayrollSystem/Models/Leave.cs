using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRPayrollSystem.Models
{
    public class Leave
    {
        [Key]
        public int LeaveId { get; set; }

        [Required]
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public string LeaveType { get; set; } // Sick, Casual, Annual, etc.

        [Required]
        public string Status { get; set; } // Pending, Approved, Rejected

        [StringLength(500)]
        public string Reason { get; set; }

        // Navigation property
        public virtual Employee? Employee { get; set; }
    }


}
