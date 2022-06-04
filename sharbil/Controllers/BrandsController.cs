using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharbil.Controllers
{
    public class BrandsController : Controller
    {
        public IActionResult Brands()
        {
            return View();
        }
        public IActionResult AddBrand()
        {
            return View();
        }
    }
}
