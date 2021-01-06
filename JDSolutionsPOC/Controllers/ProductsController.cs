using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JDSolutionsPOC.Controllers
{
    public class ProductsController : Controller
    {
        [HttpGet("productos/pacfe")]
        public IActionResult PACFE()
        {
            return View();
        }
        [HttpGet("productos/bluehouse")]
        public IActionResult BlueHouse()
        {
            return View();
        }
    }
}
