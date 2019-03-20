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

        // proberen Async maken
        public IActionResult Resolve(string hostName)
        {
            string adressen = "Het IP adres van " + hostName + ": \n";
            var result = Dns.GetHostAddressesAsync(hostName).Result;
            foreach (var item in result)
            {
                adressen += item.ToString()+"\n";
            }
            return Content(adressen);
            
        }
    }
}