using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AG_Practice.Service;

namespace AG_Practice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var productService = new ProductService();
            var product = productService.GetProduct(680);  // Hard coded just for testing purposes
            return View(product);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}