using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasitAlisVeris.Models
{
    public class ProductImage
    {
        [Key]
        public int ProductImageID { get; set; }

        public string ImageName { get; set; } = string.Empty;

        [ForeignKey("Product")]
        public int ProductID { get; set; }


    }
}
