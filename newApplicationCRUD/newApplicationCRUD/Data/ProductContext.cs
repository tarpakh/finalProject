using Microsoft.EntityFrameworkCore;
using newApplicationCRUD.Models;
namespace newApplicationCRUD.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options):base(options) { }

        public DbSet<Products> Products { get; set; }
    }
}
