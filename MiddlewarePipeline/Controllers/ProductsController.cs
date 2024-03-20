using MiddlewarePipeline.Models;

namespace MiddlewarePipeline.Controllers;

public class ProductsController
{
    private readonly List<Product> _products;

    public ProductsController(HttpContext httpContext)
    {
        _products = new()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "Powerful laptop with high-performance specs.",
                    Price = 1299.99m,

                },
                new Product()
                {
                    Id = 2,
                    Name = "Smartphone",
                    Description = "Latest smartphone with advanced features.",
                    Price = 799.99m,
                }
            };
    }

    public IEnumerable<Product> GetAllProducts() => _products;
        


    public Product GetProductById(int id) => _products.Find(t => t.Id == id);
}



