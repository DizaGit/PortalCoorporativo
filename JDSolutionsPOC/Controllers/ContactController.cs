using JDInvoiceManager.Helper.CurrentSystem;
using JDInvoiceManager.Helper.Email;
using JDSolutionsPOC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JDSolutionsPOC.Controllers
{
    public class ContactController : Controller
    {
        private IMailSender _sender;
        public ContactController(IMailSender sender)
        {
            _sender = sender;
        }
        [HttpGet("contacto")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("contacto/enviar")]
        public IActionResult SendMail([FromForm]ContactFormData data)
        {
            ResponseGeneric r = _sender.SendMail("disa@jdsolutions.com.mx", "Contacto", data.subject, $"{data.email} - {data.message}");
            return Json(r);
        }
        public IActionResult ContactPartial()
        {
            return View();
        }
    }
}
