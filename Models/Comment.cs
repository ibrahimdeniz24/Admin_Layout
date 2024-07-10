using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasitAlisVeris.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        public string CommandDescription { get; set; }=string.Empty;

        public int CommentUserName { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        public Product? Product { get; set; }
    }
}
