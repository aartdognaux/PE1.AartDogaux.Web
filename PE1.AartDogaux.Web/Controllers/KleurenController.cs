using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PE1.AartDognaux.Lib;
using System.Text;


namespace PE1.AartDognaux.Web.Controllers
{
    public class KleurenController : Controller
    {
        // int aantalkleuren meegeven als parameter
        public IActionResult Index(int aantal = 10)
        {
            StringBuilder html = new StringBuilder();
            // inline block van maken
            string begin = "<div style=\"width:75px; height:50px; display:inline-block; background:";
            string eind = " ;\"></div>";
            // stringbuilder maken hier
            // begin en eind divs maken in string
            // met stringbuilder appenden en die twee divs aan elkaar plakken
            html.Append($"<h2>Kleuren</h2>");
            foreach (string RGBwaarden in KleurenService.GenereerCssKleuren(aantal))
            {
                html.Append($"{begin}{RGBwaarden}{eind}");
            }

            html.Append($"<br><br><br> <h2>Grijs Tinten</h2>");

            foreach (string Grijswaarden in KleurenService.GenereerGrijsTinten(aantal))
            {
                html.Append($"{begin}{Grijswaarden}{eind}");
            }

            html.Append($"<br><br><br> <h2>Kleur Varianten</h2>");
            //foreach met kleurvarianten
            foreach (string RGBwaarden in KleurenService.GenereerCssKleuren(aantal,Variant.Roodachtig))
            {
                html.Append($"{begin}{RGBwaarden}{eind}");
            }
            html.Append($"<br><br><br>");
            foreach (string RGBwaarden in KleurenService.GenereerCssKleuren(aantal, Variant.Blauwachtig))
            {
                html.Append($"{begin}{RGBwaarden}{eind}");
            }
            html.Append($"<br><br><br>");
            foreach (string RGBwaarden in KleurenService.GenereerCssKleuren(aantal, Variant.Groenachtig))
            {
                html.Append($"{begin}{RGBwaarden}{eind}");
            }
            return Content(html.ToString(),"text/html");


        }
    }
}