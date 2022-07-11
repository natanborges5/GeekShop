using GeekShop.ProductAPI.Data.ValueObjects;
using GeekShop.ProductAPI.Repository;
using GeekShop.ProductAPI.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShop.ProductAPI.Controllers
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

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<ProductVo>>> FindAll()
        {
            var products = await _repository.FindAll();
            return Ok(products);
        }
        [HttpGet("{id}")]
        [Authorize]
        public  async Task<ActionResult<ProductVo>> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if(product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ProductVo>> Post([FromBody]ProductVo product)
        {
            if (product == null) return BadRequest();
            try
            {
                var newProduct = await _repository.Create(product);
                return Ok(newProduct);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Authorize]
        public async Task<ActionResult> Edit([FromBody] ProductVo product)
        {
            if (product == null) return BadRequest();
            var editedProduct = await _repository.Update(product);
            return Ok(editedProduct);
        }
        [HttpDelete("{id}")]
        [Authorize(Roles = Role.Admin)]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if(!status) return BadRequest();
            return Ok(status);
        }

    }
}
