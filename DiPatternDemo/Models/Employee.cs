using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiPatternDemo.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int EmpId {  get; set; }
        [Required]
        [Display(Name ="Employee Name")]
        public string? Name { get; set; }
        [Required]
        [Display(Name = "Employee Email")]
        public string? Email {  get; set; }
        [Required]
        [Display(Name = "Employee Salary")]
        public decimal Salary {  get; set; }
    }
}
