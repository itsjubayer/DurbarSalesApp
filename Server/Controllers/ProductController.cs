using DurbarSalesApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DurbarSalesApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("GetProducts")]
        public ActionResult<List<Product>> GetProduct()
        {
            return _productService.GetProducts();
        }

        [HttpPost]
        [Route("AddProduct")]
        public ActionResult AddProduct([FromBody] Product product)
        {
            _productService.AddProduct(product);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteProduct")]
        public ActionResult DeleteProduct([FromQuery] string productCode) 
        {
            _productService.DeleteProduct(productCode);
            return Ok();
        }
    }
}
