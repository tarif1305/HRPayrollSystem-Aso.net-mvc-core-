using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRPayrollSystem.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }

        [Required]
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan CheckIn { get; set; }

        [Required]
        public TimeSpan CheckOut { get; set; }

        public bool IsPresent { get; set; }
        public bool IsLate { get; set; }

        // Navigation property
        public virtual Employee? Employee { get; set; } 
    }
}