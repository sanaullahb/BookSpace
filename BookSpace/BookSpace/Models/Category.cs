using System.ComponentModel.DataAnnotations;

namespace BookSpace.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        [Range(1,100,ErrorMessage ="Number must be between 1 and 100")]
        [Display(Name ="Display Order")]
        public string DisplayOrder { get; set; }    
    }
}
