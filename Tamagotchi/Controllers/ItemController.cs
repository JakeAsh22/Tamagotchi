using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Tamagotchi.Models
{
    public class ItemsController : Controller
    {
        [HttpGet("/items")]
        public ActionResult Index()
        {
            List<Pet> allPets = Pet.GetAll();
            return View(allPets);
        }

        [HttpGet("items/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/items")]
        public ActionResult Create(string name)
        {
            Pet myPet = new Pet(name);
            return RedirectToAction("Index");
        }
    }
}