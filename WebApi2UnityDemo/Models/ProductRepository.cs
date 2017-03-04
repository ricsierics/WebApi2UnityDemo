using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2UnityDemo.Models
{
    public class ProductRepository : IProductRepository
    {
        private ProductsContext _context = new ProductsContext();

        public void Add(Product product)
        {
            var _context = new ProductsContext();
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(s => s.Id == id);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}