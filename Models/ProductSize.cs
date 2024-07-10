using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasitAlisVeris.Models
{
    public class ProductSize
    {
        [Key]
        public int ProductSizeID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product? Products { get; set; }

        [ForeignKey("Size")]
        public int SizeID { get; set; }
        public Size? Size { get; set; }
    }
}
