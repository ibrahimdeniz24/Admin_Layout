using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasitAlisVeris.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }
        [DisplayName("Alt Kategori Adı")]
        public string SubCategory_Name { get; set; }

        [Display(Name ="Kategori Adı")]
        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        public virtual Category? Category { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}
