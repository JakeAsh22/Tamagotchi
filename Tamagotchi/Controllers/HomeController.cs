using Microsoft.AspNetCore.Mvc;
using System;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet ("/")]
        public ActionResult Index() { return View(); }
    }
}