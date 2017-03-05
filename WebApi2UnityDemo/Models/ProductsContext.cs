using System.Data.Entity;

namespace WebApi2UnityDemo.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext() : base("name=ProductsContext")
        {
            Database.SetInitializer<ProductsContext>(new CustomDatabaseInitializer());
        }

        public DbSet<Product> Products { get; set; }
    }
}