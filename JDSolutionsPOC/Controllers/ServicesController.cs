using JDSolutionsPOC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JDSolutionsPOC.Controllers
{
    public class ServicesController : Controller
    {
        private IOptionsSnapshot<ServicesInfo> _services { get; set; }
        public ServicesController(IOptionsSnapshot<ServicesInfo> services)
        {
            _services = services;
        }
        [HttpGet("servicios")]
        public IActionResult Index()
        {
            return View(_services.Value);
        }
        [HttpGet("servicios/grupo/{groupId}")]
        public IActionResult GroupBy(string groupId)
        {
            IEnumerable<Service> services = _services.Value.Services.Where(s => s.groupid == groupId);
            if (services == null || services.Count() == 0)
                return NotFound();
            return View(services);
        }
        [HttpGet("servicios/{serviceId}")]
        public IActionResult Detail(string serviceId)
        {
            Service service = _services.Value.Services.FirstOrDefault(s => s.id == serviceId);
            if (service == null)
                return NotFound();
            return View(service);
        }
    }
}
