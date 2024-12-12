using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiPatternDemo.Models
{
    [Table("usr")]
    public class User
    {
        [Key]
        public int UId {  get; set; }
        [Required]
        [Display(Name ="User name")]
        public string? UserName { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string? Email { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string? Password {  get; set; }
    }
}
