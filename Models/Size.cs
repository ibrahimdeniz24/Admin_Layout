using System.ComponentModel.DataAnnotations;

namespace BasitAlisVeris.Models
{
    public class Size
    {
        [Key]
        public int SizeID { get; set; }
        public string SizeName { get; set; }

        public List<ProductSize>? ProductSizes { get; set; }
    }
}
