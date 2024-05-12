using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky_Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Category")]
        [Range(1,100, ErrorMessage ="لفطا بین عدد 1 تا 100 انتخاب کنید")]
        public int DisplayOrder { get; set; }
    }
}
