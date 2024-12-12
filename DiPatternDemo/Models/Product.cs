using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiPatternDemo.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name ="Product Name")]
        public string? ProductName {  get; set; }
        [Required]
        [Display(Name = "Product Price")]
        public int Price { get; set; }
        [Required]
        [Display(Name = "Category ID")]
        public int CategoryId {  get; set; }
        public string? ImageUrl { get; set; }
        [NotMapped]
        [Display(Name = "Category Name")]
        public string? CategoryName { get; set; }
    }
}
