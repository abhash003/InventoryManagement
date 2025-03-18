using Data.Model;
using Data.Repository.Repository.ProductRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _iproductRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _iproductRepository = productRepository;
        }

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return  _iproductRepository.GetAllProductsAsync();
        }

        // POST: api/products
        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            _iproductRepository.AddProducts(product);
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }

        // PUT: api/products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

           var item =  _iproductRepository.GetProduct(id);

            if (item == null)
            {
                return NotFound();
            }

            _iproductRepository.UpdateProduct(product);

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            var item = _iproductRepository.GetProduct(id);
            return item == null ? false : true;
        }
    }
}
