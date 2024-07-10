using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasitAlisVeris.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [DisplayName("Kategori Adı")]
        public string Category_Name { get; set; } = string.Empty;

        public virtual ICollection<SubCategory>? SubCategories { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
