using System.Collections.Generic;
using System.Linq;
using MyBackendApi.Data;
using MyBackendApi.Models;
using MyBackendApi.Services.Interface;

namespace MyBackendApi.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }


        public Product GetProductById(int id)
        {
            return GetProductById(id, _context.Products.FirstOrDefault());
        }

        public Product GetProductById(int id, Product? product)
        {
            return product;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

    }
}





