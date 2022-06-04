using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharbil.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Categories()
        {
            return View();
        }
     public IActionResult AddCategories()
        {
            return View();
        }
    }
}
