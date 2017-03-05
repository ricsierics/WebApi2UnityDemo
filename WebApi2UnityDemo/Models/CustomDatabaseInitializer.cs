using System.Data.Entity;

namespace WebApi2UnityDemo.Models
{
    public class CustomDatabaseInitializer : /*DropCreateDatabaseAlways<ProductsContext> */CreateDatabaseIfNotExists<ProductsContext>
    {
        protected override void Seed(ProductsContext context)
        {
            base.Seed(context);

            //Populate Products table
            var product1 = new Product() { Name = "Toothpase", Price = 40.00M };
            var product2 = new Product() { Name = "Soap", Price = 30.00M };
            var product3 = new Product() { Name = "Milk", Price = 25.50M };

            context.Products.Add(product1);
            context.Products.Add(product2);
            context.Products.Add(product3);

            context.SaveChanges();
        }
    }
}