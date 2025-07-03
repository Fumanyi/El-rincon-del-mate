using System.Diagnostics;
using ElRinconDelMate.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ElRinconDelMate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> carruselImagenes = new List<string>
            {
                "/images/mate-1.jpg",
                "/images/bebiendo-mate.jpg",
                "/images/mate-calabaza-wide-lite.png",
                "/images/tomando-mate.jpg",
                "/images/mate-close.jpg",
                "/images/mateelec.webp",
                "/images/gaucho mate.webp",
            };

            ViewBag.CarruselImagenes = carruselImagenes;

            return View();
        }
    }
}
