using GeekShop.Web.Models;
using GeekShop.Web.Services.IServices;
using GeekShop.Web.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekShop.Web.Controllers
{

    public class ProductController : Controller
    {
        private readonly IProductService _product;

        public ProductController(IProductService product)
        {
            _product = product;
        }
        [Authorize]
        public async Task<IActionResult> ProductIndex()
        {
            var products = await _product.FindAllProducts();
            return View(products);
        }
        public async Task<IActionResult> ProductCreate()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ProductCreate(ProductModel productModel)
        {
            if (ModelState.IsValid)
            {
                var response = await _product.CreateProduct(productModel);
                if(response != null) return RedirectToAction(nameof(ProductIndex));
            }
            return View(productModel);
        }
        public async Task<IActionResult> ProductUpdate(int id)
        {
            var product = await _product.FindProductsById(id);
            if(product != null) return View(product);
            return NotFound();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ProductUpdate(ProductModel productModel)
        {
            if (ModelState.IsValid)
            {
                var response = await _product.UpdateProduct(productModel);
                if (response != null) return RedirectToAction(nameof(ProductIndex));
            }
            return View(productModel);
        }
        [Authorize]
        public async Task<IActionResult> ProductDelete(int id)
        {
            var product = await _product.FindProductsById(id);
            if (product != null) return View(product);
            return NotFound();
        }
        [Authorize(Roles = Role.Admin)]
        [HttpPost]
        public async Task<IActionResult> ProductDelete(ProductModel productModel)
        {
            var response = await _product.DeleteProduct(productModel.Id);
            if (response) return RedirectToAction(nameof(ProductIndex));
            return View(productModel);
        }
    }
}
