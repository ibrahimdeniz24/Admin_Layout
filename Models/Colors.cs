using System.ComponentModel.DataAnnotations;

namespace BasitAlisVeris.Models
{
    public class Colors
    {
        [Key]
        public int ColorID { get; set; }

        public string ColorName { get; set;}

        public List<ProductColor>? ProductColors { get; set; }
    }
}
