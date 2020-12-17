using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AG_Practice.Service;

namespace AG_Practice.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        public ActionResult Index()
        {
            var product = _productService.GetProduct(680);  // Hard coded just for testing purposes
            return View(product);
        }

        public ActionResult Wizard()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}