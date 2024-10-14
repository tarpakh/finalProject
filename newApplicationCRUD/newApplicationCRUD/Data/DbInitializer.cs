using newApplicationCRUD.Models;
using System.Linq;
namespace newApplicationCRUD.Data
{
    public class DbInitializer
    {

        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Products[]
            {
                new Products { Name = "HDD", Price = 6000, Quantity = 1 },
                new Products { Name = "Monitor", Price = 8000, Quantity = 1 },
            };

            foreach (var p in products)
            {
                context.Products.Add(p);
            }

            context.SaveChanges();
        }
    }
}
