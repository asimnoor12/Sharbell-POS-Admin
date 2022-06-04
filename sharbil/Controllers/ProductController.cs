using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharbil.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult AddProduct()
        {
            return View();
        }
       

        public IActionResult ViewProduct()
        {
            return View();
        }
        public IActionResult ProductVarient()
        {
            return View();
        }
    }
}
