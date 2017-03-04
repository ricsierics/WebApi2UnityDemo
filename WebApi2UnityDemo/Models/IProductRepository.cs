using System.Collections.Generic;

namespace WebApi2UnityDemo.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
    }
}