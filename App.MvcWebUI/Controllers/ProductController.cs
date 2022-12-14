using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace App.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();
            var model = new ProductListViewModel
            {
                Products = products
            };
            return View(model);
        }
    }
}
