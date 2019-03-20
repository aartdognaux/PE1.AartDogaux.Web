using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PE1.AartDognaux.Lib;



namespace PE1.AartDognaux.Web.Controllers
{
    public class KleurenController : Controller
    {
        public IActionResult Kleuren()
        {

            KleurenService kleurenService = new KleurenService();
            KleurenService.GenereerCssKleuren(10);

            KleurenService.GenereerGrijsTinten(10);
            return View();
        }
    }
}