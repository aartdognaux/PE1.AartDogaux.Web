using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PE1.AartDogaux.Web.Controllers
{
    public class KleurenController : Controller
    {
        public ViewResult Kleuren()
        {
            return View();
        }
    }
}