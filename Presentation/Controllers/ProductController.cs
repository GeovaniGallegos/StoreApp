using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.ServicesInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok( await _productService.GetAllProducts());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            return Ok(await _productService.GetProductById(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
             _productService.AddProduct(product);
            return Ok(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public ActionResult Put([FromBody] Product product)
        {
            _productService.UpdateProduct(product);
            return Ok(product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }
    }
}
