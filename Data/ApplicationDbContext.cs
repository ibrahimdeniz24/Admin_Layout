using BasitAlisVeris.Models;
using Microsoft.EntityFrameworkCore;

namespace BasitAlisVeris.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<BasitAlisVeris.Models.Colors> Colors { get; set; } = default!;
        public DbSet<BasitAlisVeris.Models.Size> Size { get; set; } = default!;

    }
}
