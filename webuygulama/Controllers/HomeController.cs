using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webuygulama.Models;
using webuygulama.service;

namespace webuygulama.Controllers
{

    public class HomeController : Controller
    {
        IProductService productService;
        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index(int? Id)
        {
            Console.WriteLine(Id);
            List<ProductModel> models=productService.getProducts();
            return View(productService.getProducts());
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
