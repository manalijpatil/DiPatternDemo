using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiPatternDemo.Models
{
    [Table("student")]
    public class Student
    {
        [Key]
        public int StuId { get; set; }
        [Required]
        [Display(Name ="Enter student Name")]
        public string? Name { get; set; }
        [Required]
        [Display(Name = "Student Branch")]
        public string? Branch {  get; set; }
        [Required]
        [Display(Name = "Student Percentage")]
        public decimal Marks { get; set; }
    }
}
