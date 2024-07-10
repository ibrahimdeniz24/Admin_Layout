using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasitAlisVeris.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [DisplayName("Kullanici Adı")]
        [Required(ErrorMessage ="Bu Alanı boş Bırakamazsınız")]
        public string AdminName { get; set; }

        [DisplayName("Kullanici Şifresi")]
        [Required(ErrorMessage = "Bu Alanı boş Bırakamazsınız")]
        [MinLength(8,ErrorMessage ="Sekiz Karakterden Az Olamaz")]
        public string AdminPassword { get; set; }


    }
}

