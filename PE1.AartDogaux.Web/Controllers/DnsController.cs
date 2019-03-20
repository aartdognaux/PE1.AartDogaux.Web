using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PE1.AartDogaux.Web.Controllers
{
    public class DnsController : Controller
    {
        public IActionResult DnsCheck(string hostname)
        {
            Dns.GetHostAddressesAsync("www.amazon.com");
            return View();
            
        }
    }
}