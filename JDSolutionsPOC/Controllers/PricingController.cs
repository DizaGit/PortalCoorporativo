using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JDSolutionsPOC.Controllers
{
    public class PricingController : Controller
    {
        [HttpGet("modelosdetrabajo")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
