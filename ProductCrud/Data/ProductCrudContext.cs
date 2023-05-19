using Microsoft.EntityFrameworkCore;
using ProductCrud.Models;

namespace ProductCrud.Data
{
    public class ProductCrudContext : DbContext
    {
        public ProductCrudContext(DbContextOptions<ProductCrudContext> options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
    }
}
