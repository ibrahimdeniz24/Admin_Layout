using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasitAlisVeris.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name ="Ürün Adı")]
        public string Product_Name { get; set; } = string.Empty;
        [Display(Name = "Ürün Açıklaması")]
        public string Product_Description { get; set;} = string.Empty;
        [Display(Name = "Ürün Görseli")]
        public string Product_Image { get; set; } = string.Empty;
        [Display(Name = "Ürün Fiyatı")]
        public decimal? Product_Price { get; set;}
        [ForeignKey("Category")]
        public int? CategoryID { get; set; }

        public virtual Category? Category { get; set; }

        [ForeignKey("SubCategory")]
        public int? Sub_CategoryID { get; set; }

        public virtual SubCategory? SubCategory { get; set; }

        [Display(Name = "Ürün Özellikleri")]
        public string Product_Feature { get; set; }=string.Empty;

        public List<ProductColor>? ProductColors { get; set; }

        public List<ProductSize>? ProductSizes { get; set; }

        public List<Comment>? ProductComments { get; set; }

        [NotMapped]
        public IFormFile? PictureImage { get; set; } //gönderdiğimiz dosyaları taşımak için oluşturduk veritabanında olmayacak.

    }
}
