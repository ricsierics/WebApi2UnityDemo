using System.Web.Http;
using WebApi2UnityDemo.Models;

namespace WebApi2UnityDemo.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }
        
        //[HttpGet]
        public IHttpActionResult Get(int id)
        {
            var product = _repository.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //[HttpGet]
        public IHttpActionResult Get()
        {
            var products = _repository.GetAll();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        //[HttpPost]
        public IHttpActionResult Add(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _repository.Add(product);
            return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);
        }
    }
}
