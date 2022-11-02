using LBShop.ProductAPI.Data.ValueObjects;
using LBShop.ProductAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LBShop.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            var products = _repository.FindAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> FindById(long id) 
        {
            var product = _repository.FindById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }
    }
}
