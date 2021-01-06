using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JDSolutionsPOC.Controllers
{
    public class AboutUsController : Controller
    {
        [HttpGet("nosotros")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
