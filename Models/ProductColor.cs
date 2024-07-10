using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasitAlisVeris.Models
{
    public class ProductColor
    {
        [Key]
        public int ProductColorID { get; set; }


        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product? Products { get; set; }

        [ForeignKey("Color")]
        public int ColorID { get; set; }

        public Colors? Colors { get; set; }
    }
}
